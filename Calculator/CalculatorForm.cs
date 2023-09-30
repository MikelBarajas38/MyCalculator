/*
 * Interfaces Gráficas con Aplicaciones: Examen (Calculadora)
 * Mikel Barajas 336483
 * Ingeniería en Sistemas Inteligentes
 * 14/09/23
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{

    public partial class CalculatorForm : Form
    {

        public String currentExpression = "";
        public String currentNum = "";
        public string pastNum = "";
        public bool operationIsDone = false;

        public CalculatorForm()
        {
            InitializeComponent();
            initOperation();
        }

        public void modifyCurrentNum(string digit)
        {
            if(operationIsDone) 
            {
                initOperation();
            }

            currentNum += digit;
            calcTextBox.Text = currentNum;
        }

        public void setLhsExpression(string op)
        {

            if(currentNum == "")
            {
                return;
            }

            if (!operationIsDone) //nested operations
            {
                evalExpression(); 
            } 

            operationIsDone = false;

            currentExpression = $"{currentNum} {op}";
            currentNum = "";
            operationLabel.Text = currentExpression;
            calcTextBox.Text = currentNum;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            evalExpression();
        }

        public void initOperation()
        {
            currentExpression = "";
            currentNum = "";
            calcTextBox.Text = currentNum;
            operationLabel.Text = currentExpression;
            operationIsDone = false;
        }

        public void evalExpression()
        {
            if (currentNum == "")
            {
                return;
            }

            if (operationIsDone)
            {
                return;
            }

            Double testInput;
            if (!Double.TryParse(currentNum, out testInput))
            {
                MessageBox.Show("Entrada inválida", "ERROR");
                initOperation();
                return;
            }

            currentExpression += $" {currentNum}";
            operationLabel.Text = $"{currentExpression} = ";

            try
            {
                String evalExpression = currentExpression;
                if (currentNum == "0") evalExpression += ".0"; // catch div by zero
                currentNum = Evaluate(evalExpression).ToString();
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Operación inválida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                initOperation();
                return;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("División por 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                initOperation();
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Operación inválida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                initOperation();
                return;
            }
            catch (OverflowException) {
                MessageBox.Show("Overflow", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                initOperation();
                return;
            }

            calcTextBox.Text = currentNum;
            pastNum = currentNum;
            operationIsDone = true;

            //Could add history with a string stack and pushing $"{currentExpression} = {currentNum}"
        }

        //evaluate expression using DAO.Net datatable
        public static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            if(currentNum.StartsWith("-"))
            {
                currentNum = currentNum.Substring(1);
            }
            else
            {
                currentNum = $"-{currentNum}";
            }
            calcTextBox.Text = currentNum;
        }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            initOperation();
        }

        private void ansBtn_Click(object sender, EventArgs e)
        {
            currentNum = pastNum;
            calcTextBox.Text = currentNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreditsForm creditsForm = new CreditsForm();
            creditsForm.Show();
        }
    }

    public class NumberButton : System.Windows.Forms.Button
    {
        protected override void OnClick(EventArgs e)
        {
            CalculatorForm form = (CalculatorForm)this.Parent;
            form.modifyCurrentNum((String) this.Tag);
            base.OnClick(e);
        }

    }

    public class OperatorButton : System.Windows.Forms.Button
    {
        protected override void OnClick(EventArgs e)
        {
            CalculatorForm form = (CalculatorForm)this.Parent;
            form.setLhsExpression((String)this.Tag);
            base.OnClick(e);
        }
    }
}

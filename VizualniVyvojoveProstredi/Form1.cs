namespace VizualniVyvojoveProstredi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tato jedna metoda obslouží kliknutí na jakékoliv tlaèítko v paletì
        private void AddOnClick(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            FlowNode newFlowNode = null;

            switch (ClickedButton.Text)
            {
                case "START":
                    newFlowNode = new StartNode();
                    break;

                case "END":
                    newFlowNode = new EndNode();
                    break;

                case "INPUT":
                    newFlowNode = new InputNode();
                    break;

                case "OUTPUT":
                    newFlowNode = new OutputNode();
                    break;

                case "ACTION":
                    newFlowNode = new ActionNode();
                    break;

                case "IF":
                    newFlowNode = new IfNode();
                    break;

                case "WHILE":
                    newFlowNode = new WhileNode();
                    break;
            }

            if (newFlowNode != null)
            {
                newFlowNode.Location = new Point(30, 30);

                panel4.Controls.Add(newFlowNode);
                newFlowNode.BringToFront();
            }
        }
    }
}
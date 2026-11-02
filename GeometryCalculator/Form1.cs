namespace GeometryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCircle_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Rectangle
            if (double.TryParse(TxtLength.Text, out double length) &&
                double.TryParse(TxtWidth.Text, out double width))
            {
                double RectangleArea = length * width;
                double rectanglePerimeter = 2 * (length + width);

                lblRectangle.Text = $"Rectangle Area: {RectangleArea}";
            }
            else
            {
                lblRectangle.Text = "Invalid rectangle dimensions.";
            }

            //Circle
            if (double.TryParse(TxtRadius.Text, out double radius))
            {
                double circleArea = Math.PI * radius * radius;
                double circleCircumference = 2 * Math.PI * radius;

                lblCircle.Text = $"Circle Area: {circleArea:F2}";
            }
            else
            {
                lblCircle.Text = "Invalid circle radius.";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

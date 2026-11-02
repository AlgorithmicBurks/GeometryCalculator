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

                TxtRectangleAreaResult.Text = RectangleArea.ToString();

                double rectanglePerimeter = 2 * (length + width);
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

                TxtCircleAreaResult.Text = circleArea.ToString("F2");
                TxtCircumferenceResult.Text = circleCircumference.ToString("F2");
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

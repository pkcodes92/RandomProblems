namespace GeometrySample
{
    public class Shape : IOperations
    {
        #region Properties
        private double Width { get; set; }
        private double Height { get; set; }
        #endregion

        public void setWidth(double widthValue)
        {
            Width = widthValue;
        }

        public void setHeight(double heightValue)
        {
            Height = heightValue;
        }

        #region Implementing the IOperations interface
        public double calculateArea(double width, double height)
        {
            return width * height;
        }

        public double calculatePerim(double width, double height)
        {
            return ((2 * width) + (2 * height));
        }
        #endregion
    }
}
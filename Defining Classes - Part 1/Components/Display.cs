namespace GSM.Components
{
    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display()
            : this(0, 0)
        {
        }

        public Display(double size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("This size is invalid");
                }

                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (this.numberOfColors <= 0)
                {
                    throw new System.ArgumentException("This number of colors is invalid");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return "Size:" + this.size + " " + "NumberOfColors:" + this.numberOfColors + " ";
        }
    }
}
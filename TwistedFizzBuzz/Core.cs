namespace TwistedFizzBuzz
{
    public class Core
    {
        private int minRange;
        private int maxRange;
        private List<Element> elements; // TODO: Consider using a Dictionary instead (Is easier to give a value to the elements list, because there's no need to initialize multiple Element objects)

        /// <summary>
        /// FizzBuzz with default settings
        /// </summary>
        public Core() {
            minRange = 1; 
            maxRange = 100;
            InitializeElements();
        }

        /// <summary>
        /// FizzBuzz with a given range
        /// </summary>
        /// <param name="minRange">Initial number of the sequence</param>
        /// <param name="maxRange">Final number of the sequence</param>
        /// <exception cref="ArgumentException"></exception>
        public Core(int minRange, int maxRange)
        {
            if (minRange > maxRange)
                throw new ArgumentException("ARGUMENT EXCEPTION: Min range value cannot be bigger than Max range value");

            this.minRange = minRange;
            this.maxRange = maxRange;
            InitializeElements();
        }

        /// <summary>
        /// FizzBuzz with a given range, and a given list of multiples with each word related to the multiple.
        /// </summary>
        /// <param name="minRange">Initial number of the sequence</param>
        /// <param name="maxRange">Final number of the sequence</param>
        /// <param name="elements">A list of type Element that will contain each multiple-word (All multiples should be different than 0)</param>
        /// <exception cref="ArgumentException"></exception>
        public Core(int minRange, int maxRange, List<Element> elements) {
            if(minRange > maxRange)
                throw new ArgumentException("ARGUMENT EXCEPTION: Min range value cannot be bigger than Max range value");

            if (elements.Any(el => el.multiple == 0))
                throw new ArgumentException("ARGUMENT EXCEPTION: At least one of the given multiples is a 0. Dividing by 0 is not possible.");

            this.minRange = minRange;
            this.maxRange = maxRange;
            this.elements = elements;
        }

        /// <summary>
        /// When no list of multiples is given, it will set the defaults to the list (3->Fizz & 5->Buzz)
        /// </summary>
        private void InitializeElements()
        {
            elements = [new Element("Fizz", 3), new Element("Buzz", 5)];
        }

        /// <summary>
        /// FizzBuzzing time!!!
        /// </summary>
        public void Calculate()
        {
            for (int i = minRange; i <= maxRange; i++)
            {
                string res = elements.Aggregate("", (agg, el) => agg + ((i % el.multiple) == 0 ? el.word : ""));
                Console.WriteLine(string.IsNullOrEmpty(res) ? i : res); 
            }
        }
    }
}

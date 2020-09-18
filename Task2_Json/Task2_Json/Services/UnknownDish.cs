namespace Task2_Json.Services
{
    class UnknownDish : MainCategori
    {
        public UnknownDish(string name, string category, string path)
        {
            this.path = path;

            Choice(name, category);
        }
    }
}

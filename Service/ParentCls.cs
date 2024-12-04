namespace MyAWebpp.Service
{
    public class ParentCls
    {
        //Overloading
        public virtual int Add(int num1, string abd)
        {
            int sum = num1;
            return sum;
        }
        public int Add(int num1)
        {
            int sum = num1;
            return sum;
        }

        public int Add(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            return sum;
        }

        //  public string name = "Zyz"; 
    }
}

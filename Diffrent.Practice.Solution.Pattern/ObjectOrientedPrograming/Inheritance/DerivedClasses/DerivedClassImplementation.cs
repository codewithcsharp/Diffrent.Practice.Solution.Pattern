using Diffrent.Practice.Solution.Pattern.ObjectOrientedPrograming.Inheritance.BaseClasses;

namespace Diffrent.Practice.Solution.Pattern.ObjectOrientedPrograming.Inheritance.DerivedClasses
{
    public class DerivedClassImplementation : BaseClass
    {
        public override void ShowInDerived()
        {
            Console.WriteLine("Hello show in Derived");
        }

        public int ShowOutDerived(int a)
        {
            return 0;
        }
        public void ShowOutDerived(int a, string b)
        {
            Console.WriteLine("Hello show in Derived");
        }
    }
}

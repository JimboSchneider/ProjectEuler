using Machine.Specifications;


namespace Specs.Problem1
{
    [Subject(typeof(EulerLibrary.Problem1))]
    public class When_finding_natural_numbers_below_10_of_3_and_5_sum
    {
        Establish context = () => { };

        Because of = () =>
                         {
                             problem1 = new EulerLibrary.Problem1(10);
                         };

        It Has_sum_of_23= () => problem1.Sum.ShouldEqual(23);

        static EulerLibrary.Problem1 problem1;
    }
}

using EulerLibrary;
using Machine.Specifications;

namespace ChangeMe
{
    [Subject(typeof(Problem2))]
    public class When_finding_the_final_sum
    {
        private Because of = () =>
                                 {
                                     problem2 = new Problem2();
                                 };

        It Should_be_something = () => problem2.Sum.ShouldEqual(1);

        private static Problem2 problem2;
    }
}

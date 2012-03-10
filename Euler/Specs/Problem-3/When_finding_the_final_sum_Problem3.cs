using EulerLibrary;
using Machine.Specifications;

namespace ChangeMe
{
    [Subject(typeof(Problem3))]
    public class When_finding_the_final_sum_Problem3
    {
        Establish context = () =>
                                {
                                    problem3 = new Problem3(600851475143);
                                };

        Because of = () => {};

        It Should_not_be_null = () => problem3.ShouldNotBeNull();
        It Should_find_LargestPrime = () => problem3.LargestPrime.ShouldEqual(1);

        static Problem3 problem3;
    }
}

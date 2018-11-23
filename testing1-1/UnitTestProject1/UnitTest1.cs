using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            Reservation  res = new  Reservation();
            var Result = res.CanBeCancelledBy(new User { IsAdmin = true });

            Assert.IsTrue(Result);

        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            var user = new User();
            Reservation res = new Reservation();
            var Result = res.CanBeCancelledBy(user);

            Assert.IsTrue(Result);

        }
    }
}

           
        
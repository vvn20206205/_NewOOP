//AmountException
// Khi một trợ giảng Senior nhận lương ít hơn 60,000
// Khi hoa hồng (bonus) lớn hơn 10,000
namespace AmountException {

    public class Senior_Exception : ApplicationException {
        public Senior_Exception()
        : base("Senior teaching assistants receive a salary of less than 60,000") { }
    }
    public class Bonus_Exception : ApplicationException {
        public Bonus_Exception() : base("Commission (bonus) greater than 10,000") { }
    }
}
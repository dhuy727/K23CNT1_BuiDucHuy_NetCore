namespace Bdhlession07.Models
{
    public class BdhEmployee
    {
        public int BdhId { get; set; }              // Mã nhân viên
        public string BdhName { get; set; }         // Họ tên
        public DateTime BdhBirthDay { get; set; }   // Ngày sinh
        public string BdhEmail { get; set; }        // Email
        public string BdhPhone { get; set; }        // Số điện thoại
        public decimal BdhSalary { get; set; }      // Lương
        public bool BdhStatus { get; set; }         // Trạng thái (true = đang làm việc, false = nghỉ việc)
    }
}

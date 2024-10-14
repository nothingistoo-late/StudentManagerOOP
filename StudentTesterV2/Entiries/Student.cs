using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Entiries
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        // một class có bao nhiêu constructor: có vô số, ban muốn fill data kiểu nào??: _id only; _id _name (*),...
        // điều gì sẽ xảy ra nếu bạn không tạo constructor => runtime sẽ tạo cho bạn 1 constructor defaults/ emty constructor
        // khi xài cst default, thông tin đc đổ vào như thế nào???
        // ngoài đời giống tình huống: cô giao dịch viên đưa cho mình cái form trắng(photo, in từ cái form gốc)
        // mình chưa điền, chưa full infor nhưng nó vẫn là phiên bản của mình
        // ta vẫn new dc 1 object nhưng infor bỏ trống, defaults
        // String => emty
        // số => 0

        // tuy nhiên ta có thể chủ động tạo sẵn 1 constructor default(EXPLICIT EMTY CONTSTRUCTOR) - tường minh rõ ràng
        // ngầm tạo giúp mình gọi là implicit emty constructor
        //                            không tường minnh

        // tạo siêu nhanh
        public Student() { } //explicit emty cst

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

       
        // có bao nhiêu cst, có bấy nhiêu cách new object
        // new class đã có sẵn cst nào đó, thì runtime kh giúp tạo gúp emty cst nữa, trừ khi bạn chủ động tạo explicit nó
        // mục tiêu cuối: class cần có ít nhất 1 cst để đúc object 
        // taọ cst emty và cái cst khác:

        // đúc xong thì có object, ta sẽ xem Get(), sửa Set(), xem tất cả FlextProfile(),
        public void FlexProfile() => Console.WriteLine($"{_id} {_name} {_yob} {_gpa}");

        public override string? ToString() => $"{_id} {_name} {_yob} {_gpa}";

        //GET và SET: thay đổi infor của object, lấy từng miếng infor của object
        // ToString() Flex() là lấy hết
        // lý thuyết: có N fields, thì có Nx2 hàm Get(), Set()
        //4 fields = 8 hàm 

        //GET
        public string GetId() => _id;
        public string GetName => _name;
        public int GetYob => _yob;
        public double GetGpa => _gpa;

        //SET
        // mọi hàm set luôn cần 1 value đưa vào. Hàm dưới là id 
        public void SetID(string id) => _id = id;
        public void SetName(string name) => _name = name;
        public void SetYob(int yob) => _yob = yob;
        public void SetGpa(double gpa) => _gpa = gpa;

        // đoạn code get/set viết theo style này viết rất nhàm chán nhưng vẫn phải làm, vì nó giúp objec có tương tác:cung cấp in4, tiếp nhận in4
        // bắt buộc phải làm, lặp đi lặp lại mà nhàm chán
        // ngta gọi là boiler plate 

        // C# sẽ giúp bạn 1 style mới, java chưa có tránh code boiler plate 

        // C# gộp cho gọn gọi là PROPERTY:
        // - Biến có 2 ý nghĩa Get và Set rồi
        // - C# có style trai bao, tiếp tân, hàm lai biến, biến lai hàm, style nhân mã, người cá
        



        //một biến bất kì ví dụ như là
        int yob = 2004;
        // ta muốn get value của nó, tên biến là đủ
        // xài tên biến là get, get là lấy thông tin 
        // cw(yob); /// lấy value và in ra

        // ta muốn set value cho biến
        // tên biến = value 
        // yob = 2006; Set value 2006 cho yob 

        // bản thân 1 biến đã mang 2 ý nghĩa get và set
        // có cần 1 cái hàm để bao cái hành động lại hay không
        
    }
}

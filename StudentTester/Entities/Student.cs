using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ~                 java.ultil 
namespace StudentTester.Entities
{
    public class Student
    {
        private string _id;    //ID  : _________________
        private string? _name; //Name: _________________
        private int _yob;      //Yor : _________________
        private double _gpa;   //GPA : _________________
                               //class như một cái khuyên, template, form, biểu mẫu (để diền vào), blue-print(dàn khung, bản phác thảom bản thiết kế)

        // là tên gọi chung cho 1 nhóm object chia sẻ chung nhiều đặc tính và hành vi(fields, behaviou, method)

        // để có 1 object, để có 1 đối tượng, 1 hồ sơ cv nhập học, ta phải điền vào form ở trên, trước khi điền form ta phải photo 1 form trắng - new (clone, photo)
        // sau đó ta fill info, đổ info vào (tham số hàm)
        // fill vào để tạo ra 1 object - Construct/ Constructor(tham số vật liệu đưa vào)
        // new         Student               (...)
        // clone form  gọi phễu
        // xin ram     nhận vật liệu         vật liệu đưa vào 

        // object này gọi tên là gì? Student Tèo = , Student Tí = ;

        // phần code còn lại y chang java
        // Constructor để đúc object
        // các hàm Get(), Set(), ToString() ~ FlexProfile()

        // phễu 
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;     // kh cần xài this. vì không có sự nhầm lẫn 
            _name = name; // trong biến đầu vào và đặc tính của object
            _yob = yob;
            _gpa = gpa;
        }

        // các hàm truyền thống của java here!! 100% giống 

        public void FlexProfile() => Console.WriteLine($"ID := {_id} | Name := {_name} | YOB := {_yob} | GPA := {_gpa}");

        //Console.Write("ID := " + _id+" ");
        //Console.Write("Name := {0} ", _name);
        //Console.Write($"Yob := {_yob} " );
        //Console.WriteLine($"GPA := {_gpa} ");

        // Console.WriteLine("ID := {0} | Name := {1} | YOB := {2} | GPA := {3}",_id,_name,_yob,_gpa);


        // object được tạo ra tức là đã dc đổ info, giống như bạn vào ngân hàng điền phiếu rút tiền, điền xong, bạn ngắm nghía tí đã, coi câu chữ rõ chưa, gọi là getInfor
        // tôi biết bạn có tên, nhưng tên đang private, vậy tôi sẽ hỏi
        // GetName() -> return trả về Name

        public string GetName() => _name;
        public int GetAge() => 2024 - _yob;//return 2024 - _yob
                                           // hard-code: Trong code có những con số cố định, 
                                           // gọi class, gọi hàm lấy ngày giờ hệ thống - _yob



        // coding convention - quy tắc đặt tên trong C#.
        // I. Tên của Solution.
        // II. Tên của project.
        // III. Tên của NameSpace.
        // IV. Tên của class, interface, deligates.
        //  1. Tên class.
        //      - Danh từ, chữ hoa từng đầu từ - Pascal Case Notation -> bắt chước theo ngôn ngữ        lập trình Pascal.
        //      * Ví dụ: Student, Lecture, Dog, Cat, File, Console, ArrayList....
        // V. Tên biến (Biến cục bộ trong hàm và biến ngoài hàm Fields).
        //  1. "Biến toàn cục" Fields/Attribute.
        //      - Danh từ, cú pháp con Lạc Đà, chữ Hoa Từng Đầu Từ, Từ Đầu Tiên Viết Chữ Thường         Kèm _ Đứng Đầu.
        //      * Ví Dụ: _id, _name, _salary, _basicSalary...
        //  2. PROPERTY (Biến lai với hàm - làm GET SET theo kiểu mlem
        // * PROPERTY là kĩ thuật viết hàm GET SET gọn gàng qua tyle xài biến, ta độ thêm 1 biến và bao cái _FIELD qua 2 hàm GET xà xà tự nhiên qua lại PROPERTY
        // Tên "Biến Lai PROPERTY phải là danh từ, chữ hoa từng đầu từ (Pascal case), kh có động từ do động từ Get Set bị che bên trong PROPERTY này
        // có nhiều kĩ thuật PROPERTY, từ V3 trở đi ta sẽ học
        //  3. Biến cục bộ (Local Variable): Biến nằm trong hàm, hoặc nằm trong tham số hàm Parameter.
        //      -Danh từ, cú pháp con Lạc Đà. Từ đầu tiên chữ thường, các từ còn lại viết chữ hoa từ đâù từ.
        //      *Ví dụ: salary, sum, count, yob, basicSalary...
        // VI. Tên hàm (Method).
        //  - Verb + Object, cú pháp Pascal, Pascal Case Notation.
        //    Chữ hoa từng đầu từ, từ đầu tiên là động từ.
        //    *Ví dụ: GetName(), Student(), ToString(), Main(), Convert(), SetName()...  

        // đổi màn hình của điện thoại, đổi avata cover của tài khoản mạng xã hội.
        // cần cbi 1c hình
        // nhấn núi, thay thế khung hình - hình mới cbi

        // đổi nền (hình mới)        set, setting, setter;
        //{
        //      Khung-hình-cũ = hình-mới
        //}
        //setting kh tạo ra object mới mà chỉ là tinh chỉnh, chỉnh sửa object cũ đang có

        //tui ban đổ bình mực lên tay kh phải mực -> màu da mới dc thiết lập tha-thu -> vẫn là ta mà
        // một SV có GPA, kì này có điểm mới, phải đổi mới
        public void SetGpa(double gpa)// convert thành expression body/bodied
        {
            _gpa = gpa;
        }

        // hắc não: hàm Set() khác với cái phễu Constructor như thế nào??
        // đều đổ in4 vào ram , vùng new
        // khác: pheu constructor moi lan goi la 1 lan xin ram cho object, tao moi object tao moi tai khoan mxh
        //ham set() moi lan goi laf do vao vung ram cu da new truoc do, chinh sua vung ram da co, kh tao moi vung ram objec
        // thang nao cung dc goi nhieu lan
        // set() ma goi giong minh make up, xamw, nhuom toc
        // ham set() la cua tung object moi nguoi co nhu cau do khac nhau -> khi goi di kem bien object, an.SetGpa(), binh.SetGpa()...

        //các sv học hành chăm chỉ
        // điểm trung bình bắt dc cập nhật
        
    }
}

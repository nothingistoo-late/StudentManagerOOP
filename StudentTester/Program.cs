using StudentTester.Entities; //.* bên java là lấy tất cả class 
//import java.util.Scanner;   java.util.*

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreateStudentObject();
        }
        static void CreateStudentObject()
        {
            //loài người luôn đặt tên cho mọi thứ quanh họ
            // double pi = 3.14
            //double VAT, discount = 0.1; // 10%

            Student an = new Student("SE1","An",2004,8.6);

            // gọi cái phễu để đổ vật liệu vào đẻ lấp vào bên trong caí khuôn để đúc 1 object, 1 bức tường
            // đổ mực lên cái phôi đã đc clone để thành 1 cái căn cước, 1c cmnd của bạn, của tôi, của ai??....

            Student binh = new("SE2", "Binh Le", 2004, 8.7);
            // new kiểu mới kh cần đi kèm datatype vì bên trái đã có khai báo rồi!!!

            // var cuong = new("SE2", "Cuong Vo", 2004, 8.8);
            // 2 bên đều không rõ ràng về datatype nên error
            var cuong = new Student("SE3", "Cuong Vo", 2004, 8.8);

            // var dung = new Student(8.9, 2006, "SE200004","Dung Pham");

            // khi goi tham so ham thi phai goi dung thu tu bien da dc xac dinh o tren ham. Constructor cung la 1 ham dac biet de clone vung ram, fill in4 cua object cai pheu cua vat lieu

            Student dung = new Student(gpa:8.9, yob:2006, name:"Dung Pham", id:"SE200004");
            // ki thuat goi ham ma kh theo thu tu cua bien, goi lon xon cung ok luon, mien la chi ra dc bien nao ung voi value nao qua ki hieu ten-bien:value
            //linh hoạt trong cách gọi hàm, kĩ thuật này dc gọi là name-argument
            //gọi hàm đi kèm tên tham số.

            // flex infor của các bạn 
            // con người có xu hướng đặt tên gọi cho mọi thứ(đơn giản và phức tạp)
            // 3.14 -> pi, 9.8 -> G, 300.000 -> price, total 
            //10%, 8% -> discount, VAT
            // {NTT, TB, 1994, NV HCM, Hải Tú} -> Sếp
            // Casi Sep = new Casi(...);
            an.SetGpa(6.8);
            an.FlexProfile();
            binh.FlexProfile();
            cuong.FlexProfile();
            dung.FlexProfile();

            // hỏi thôg tin của từng bạn nào 
           
            Console.WriteLine("An's Name := " + an.GetName());
            Console.WriteLine("Binh's Name := {0}", binh.GetName());
            Console.WriteLine($"Cuong's Name := {cuong.GetName()}");
            Console.WriteLine($"Dung's Name := {dung.GetName()}");

            var s = an;
            s.FlexProfile();

            s.SetGpa(67.89);
            Console.WriteLine("An's Profile after S ");
            an.FlexProfile();

            // cau hoi dieu gi se dien ra
            s = binh;
            Console.WriteLine("S vs Binh");

            s.FlexProfile();
            an = binh;
            Console.WriteLine("3 chang 1 nang ");
            an.FlexProfile();

            //System.GC. Garbage Collector, module trong runtime
            // chuyên đi dọn dẹp vùng new mồ côi - kh có ai trỏ đến 

        }
    }
}

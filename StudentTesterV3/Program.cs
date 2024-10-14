using StudentTesterV3.Entities;

internal class Program
    {
    private static void Main(string[] args)
    {

        // thuật ngữ var: Type Inference
        // 
        Student an = new Student("SE1", "An Nguyen", 2004, 8.6);
        Student an2 = new Student(); //cst r
        Student an3 = new(); //cst rỗng và ăn bớt vế phải -> kiểu mới
        Student an4 = new Student("SE1", "An Nguyen", 2004, 8.6);
        var an5 = new Student();// type inference\
        //hỏi an đầu tiên, full thông tin
        // hỏi an đầu tiên, chỉ hỏi tên GET() style kiểu mới
        Console.WriteLine("AN full infor: " + an);//gọi thầm tên em
        Console.WriteLine("An name: " + an.Name); //gọi thầm tên em

        var binh = new Student(yob: 2004, gpa: 8.7, name: "Binh Le", id: "SE2");
        // ở trên là NAME ARGURMENT
        Console.WriteLine($"Binh Full Infor : {binh}");// gọi thầm tên em 

        // chấn động, sử dụng get set ngay khi new!!
        var cuong = new Student();
        Console.WriteLine("Cuong info at first : {0}",cuong);//gọi thầm tên em
        // điền infor qua con đường set kiểu mlem
        //.SetName(...), SetYob(...)....
        cuong.Id = "SE3";
        cuong.Name = "Cuong Vo";
        cuong.Gpa = 8.8;
        cuong.Yob = 2005;

        //GET SET tự nhiên như đang xài biến, biến bản chất bao hàm sẵn ý nghĩa GET<SET rồi
        Console.WriteLine($"Cuong full infor after setting:=  {cuong}");

        //chấn động thật sự - new và set viết gộp 

        var dung = new Student()
        {
            Id = "SE4", //viết PROPERTY cùng dòng hay khác dòng cũng oke
            Name = "Dung Pham",
            Yob = 2006,
            Gpa = 8.9
        };
        // new và set gọi cùng lúc thay vì gọi riêng
        // cú pháp này dc gọi là OBJECT INITIALIZATION 
        // tạo object đồng thời gán luôn BACKING FIELD qua ngã PROPERTY
        Console.WriteLine($"Dung full infor:= {dung}");
    }
    }
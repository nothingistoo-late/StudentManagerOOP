using StudentTesterV2.Entiries;


namespace StudentTesterV2
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Student an = new Student();
                // toàn bộ info bên trong là default
                // chuỗi -> emty, số -> 0 
                an.FlexProfile();
                an.SetID("SE1");
                an.SetName("An Nguyen");
                an.SetYob(2004);
                an.SetGpa(8.6);
                Console.WriteLine(an.ToString());
                Console.WriteLine(an); // gọi thầm tên em
                
                // khi bạn quyết định in biến object, bên C in ra địa chỉ con trỏ
                // bên java/c# nó đi tìm hàm ToString() để chạy
                // java in ra mã hexa của vùng ram nếu class mình làm kh có hàm ToString(), đi gọi hàm của cha
                // C#: kh in mã băm vùng ram của class nếu class kh có hàm ToString(), mà nó đi gọi, trả về datatype của vùng new - tình huống này trả về Student 

                // vậy nếu mình cố tình sửa lại code ToString() được không
                // đc -> thì mới dc gọi là overrride phủ quyết, qua mặt cha, cha ngồi đó, để con lo cho



            }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV5.Entities
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        // kỹ thuật code kiểu này là kĩ thuật giấu BACKING FIELD
        // RUNTIME tự sinh ra _BACKING FIELD tương ứng với mỗi PROPERTY để dev đỡ phải gõ code nhiều những đoạn code nhàm chán
        // phía hậu trường RUNTIME tự sinh ra 1 _BACKING FIELD tương ứng
        //KỸ thuật này gọi là AUTO-GENERATIC  PROPERTY

            // đôi khi quên cú pháp auto thì làm sao
            // gõ prop tab tab rồi đổi tên lại cho phù hợp

    }
}

// khi nào xài kĩ thuật PROPERTY: FULL PROPERTY(_BACKING FIELD chủ động) và AUTO-IMPLEMENTED PROPERTY (giâos _BACKING FIELD)

// thường ta hay xài với class mà nó sẽ map với data xuống tablue
// table là nơi set data và get data, xử lí ở cây query, trong ram ở trong 1 class khác.
// kh ai cấm bạn xài PROPERTY theo dạng full hoặc dạng auto ở các class khác bất kì 

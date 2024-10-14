using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV4.Entities
{
    public class Student
    {
        private String _id;
        private String _name;
        private int _yob;
        private double _gpa;

        public Student() { }

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        // lỡ quên cách viết mà nó chưa chịu gợi í, 
        // PROPFULL TAB TAB

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Yob //REFACTOR, REFACTORING: tối ưu, tinh chỉnh code
        {
            get => _yob;
            set => _yob = value;
        }

        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }
        // sau khi có PROPERTY, thì ta làm tiếp ToString và các hàm còn lại nếu cần
        // new cách thức
        // truyền thống đủ 2 vế, ăn bớt trái - var, ăn bớt phải - bỏ datatype còn new(), named-argument, object initialization

        // get set kiểu mới dù dth, dùng tự nhiên theo style của biến = (Set) biến (get) nhưng cũng là BOILER PLATE do lặp lại thứ đã quen

        // tuyệt chiêu cuối, rút gọn tiếp get set 
    }
}

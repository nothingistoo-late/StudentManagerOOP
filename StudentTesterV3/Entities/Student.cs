using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Entities
{
    public class Student
    {
        private String _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student() { }

        public Student(String id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }


        //GET và SET
        //Id là 1 thứ lai giữa biến và hàm, bao Get(), Set() lại 
        // nhưng xài get/set qua style gán giá trị cho biến
        //cw(.Id)~~~ cw(getId()) return _id
        //.Id = "SE1", value = SE1, _id = SE1
        // chơi biến nhưng là gọi hàm => tự nhiên trong viết code
        // thay đổi giá trị biến là set, gọi tên biến là get

        // GetName(), setName() kh tự nhiên

        // Name = ... tự nhiên
        // PROPERY OF A CLASS

        //public string Name
        //{ get
        //    {
        //        return _name; //BACKING FIELD   
        //    } 
        //    set 
        //    { 
        //        _name = value;
        //    } 
        //}
        // .Id sex laf get value của Id
        // .Id = "SE123456";  -> set Id 


        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name= value; }   
        }

        public int Yob 
        {  get => _yob;
           set => _yob = value;
        } 

        public double Gpa
        { 
            get => _gpa;
            set => _gpa = value;
        }

        public override string? ToString() => $"{Id} {Name} {Yob} {Gpa}";
        
    }
}
// xài PROPERTY nghĩa là ta chế ra mọt biến lai hàm, nó bao bên trong 2 hàm get set truyên thống và 2 hàm này thao tác trên _FIELD để lưu trữ và thao tác các  ATTRIBUTE của 1 class 
//_FIELD đc gọi là hậu phuơng của biến lai Id, Name, Yob, Gpa
// đằng sau thành công của 1 người đàn ông là ...
// đằng sau PROPERTY là biến _FIELD lo cho việc get set
//                           _FIELD dc gọi tên mới: BACKING FIELD
//                           _id, _name, _yob, _gpa: BACKING FIELD 
// 
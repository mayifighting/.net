using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 控件
{
    public partial class CG : Form
    {
        hasht
        public CG()
        {
            InitializeComponent();
        }
    }
    public class Student
    {
        public Student(string StuName, char StuSex, string StuBirthday, int StuScore, string StuAddress)
        {
            this.Name = StuName;
            this.Sex = StuSex;
            this.Birthday = StuBirthday;
            this.Score = StuScore;
            this.Address = StuAddress;
        }
        public string Name;
        public char Sex;
        public string Birthday;
        public int Score;
        public string Address;
    }
}

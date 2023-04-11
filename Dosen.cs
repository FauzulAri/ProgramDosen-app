using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDosen
{
    class Dosen
    {
        private int id;
        private string nama;
        private int nik;
        private string gender;
        private string course;

        public Dosen()
        {
            this.id = 1;
            this.nama = "Dosen Pengampu";
            this.nik = 1234567890;
            this.gender = "male";
            this.course = "Pemrograman Berorientasi Objek";
        }
        public void display()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Nama: " + this.nama);
            Console.WriteLine("NIK: " + this.nik);
            Console.WriteLine("Gender: " + this.gender);
            Console.WriteLine("Course: " + this.course);
        }

        public void attDosen(string nama, int nik)
        {
            this.nama = nama;
            this.nik = nik;
        }

        public void addCourse(string course)
        {
            this.course += ", " + course;
        }
    }
}
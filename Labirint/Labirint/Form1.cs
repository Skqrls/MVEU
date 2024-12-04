using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }

        private void label111_MouseEnter(object sender, EventArgs e)
        {
            label110.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            label47.Visible = false;
            label48.Visible = false;
            label49.Visible = false;
            label50.Visible = false;
            label51.Visible = false;
            label52.Visible = false;
            label53.Visible = false;
            label54.Visible = false;
            label55.Visible = false;
            label56.Visible = false;
            label57.Visible = false;
            label58.Visible = false;
            label59.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            label62.Visible = false;
            label63.Visible = false;
            label64.Visible = false;
            label65.Visible = false;
            label66.Visible = false;
            label67.Visible = false;
            label68.Visible = false;
            label69.Visible = false;
            label70.Visible = false;
            label71.Visible = false;
            label72.Visible = false;
            label73.Visible = false;
            label74.Visible = false;
            label75.Visible = false;
            label76.Visible = false;
            label77.Visible = false;
            label78.Visible = false;
            label79.Visible = false;
            label80.Visible = false;
            label81.Visible = false;
            label82.Visible = false;
            label83.Visible = false;
            label84.Visible = false;
            label85.Visible = false;
            label86.Visible = false;
            label87.Visible = false;
            label88.Visible = false;
            label89.Visible = false;
            label90.Visible = false;
            label91.Visible = false;
            label92.Visible = false;
            label93.Visible = false;
            label94.Visible = false;
            label95.Visible = false;
            label96.Visible = false;
            label97.Visible = false;
            label98.Visible = false;
            label99.Visible = false;
            label100.Visible = false;
            label101.Visible = false;
            label102.Visible = false;
            label103.Visible = false;
            label104.Visible = false;
            label105.Visible = false;
            label106.Visible = false;
            label107.Visible = false;
            label108.Visible = false;
            label109.Visible = false;
            
            enemy.Visible = false;
            enemy1.Visible = false;
            enemy2.Visible = false;
            enemy3.Visible = false;
            enemy4.Visible = false;
            enemy5.Visible = false;
            enemy6.Visible = false;
            enemy7.Visible = false;
            enemy8.Visible = false;


        }

        private void label110_Click(object sender, EventArgs e)
        {
        }

        private void label111_Click(object sender, EventArgs e)
        {
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click_1(object sender, EventArgs e)
        {

        }
        //Обработчик действий 1

        private bool enemyMovingRight = true;
        private bool enemy1MovingLeft = true;
        private bool enemy2MovingUp = true;
        private bool enemy3MovingDown = true;
        private bool enemy4MovingRight = true;
        private bool enemy5MovingRight = true;
        private bool enemy6MovingRight = true;
        private bool enemy7MovingUp = true;
        private bool enemy8MovingRight = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Движение енеми
            if (enemyMovingRight)
                enemy.Left += 10;
            else
                enemy.Left -= 10;

            if (enemy1MovingLeft)
                enemy1.Left -= 10;
            else
                enemy1.Left += 10;

            if (enemy2MovingUp)
                enemy2.Top -= 10;
            else
                enemy2.Top += 10;

            if (enemy3MovingDown)
                enemy3.Top += 10;
            else
                enemy3.Top -= 10;

            if (enemy4MovingRight)
                enemy4.Left += 10;
            else
                enemy4.Left -= 10;

            if (enemy5MovingRight)
                enemy5.Left += 10;
            else
                enemy5.Left -= 10;

            if (enemy6MovingRight)
                enemy6.Left += 10;
            else
                enemy6.Left -= 10;

            if (enemy7MovingUp)
                enemy7.Top -= 10;
            else
                enemy7.Top += 10;

            if (enemy8MovingRight)
                enemy8.Left += 10;
            else
                enemy8.Left -= 10;

            // Проверка границ и изменение направления
            if (enemy.Left <= 0 || enemy.Right >= this.ClientSize.Width)
                enemyMovingRight = !enemyMovingRight;

            if (enemy1.Left <= 0 || enemy1.Right >= this.ClientSize.Width)
                enemy1MovingLeft = !enemy1MovingLeft;

            if (enemy2.Top <= 0 || enemy2.Bottom >= this.ClientSize.Height)
                enemy2MovingUp = !enemy2MovingUp;

            if (enemy3.Top <= 0 || enemy3.Bottom >= this.ClientSize.Height)
                enemy3MovingDown = !enemy3MovingDown;

            if (enemy4.Left <= 0 || enemy4.Right >= this.ClientSize.Width)
                enemy4MovingRight = !enemy4MovingRight;

            if (enemy5.Left <= 0 || enemy5.Right >= this.ClientSize.Width)
                enemy5MovingRight = !enemy5MovingRight;

            if (enemy6.Left <= 0 || enemy6.Right >= this.ClientSize.Width)
                enemy6MovingRight = !enemy6MovingRight;

            if (enemy7.Top <= 0 || enemy7.Bottom >= this.ClientSize.Height)
                enemy7MovingUp = !enemy7MovingUp;

            if (enemy8.Left <= 0 || enemy8.Right >= this.ClientSize.Width)
                enemy8MovingRight = !enemy8MovingRight;

            // Проверка столкновений с метками и изменение направления
            if (label77.Bounds.IntersectsWith(enemy.Bounds) || label35.Bounds.IntersectsWith(enemy.Bounds))
                enemyMovingRight = !enemyMovingRight;

            if (label68.Bounds.IntersectsWith(enemy1.Bounds) || label52.Bounds.IntersectsWith(enemy1.Bounds))
                enemy1MovingLeft = !enemy1MovingLeft;

            if (label2.Bounds.IntersectsWith(enemy2.Bounds) || label30.Bounds.IntersectsWith(enemy2.Bounds))
                enemy2MovingUp = !enemy2MovingUp;

            if (label105.Bounds.IntersectsWith(enemy3.Bounds) || label53.Bounds.IntersectsWith(enemy3.Bounds))
                enemy3MovingDown = !enemy3MovingDown;

            if (label66.Bounds.IntersectsWith(enemy4.Bounds) || label104.Bounds.IntersectsWith(enemy4.Bounds))
                enemy4MovingRight = !enemy4MovingRight;

            if (label41.Bounds.IntersectsWith(enemy5.Bounds) || label62.Bounds.IntersectsWith(enemy5.Bounds))
                enemy5MovingRight = !enemy5MovingRight;

            if (label3.Bounds.IntersectsWith(enemy6.Bounds) || label49.Bounds.IntersectsWith(enemy6.Bounds))
                enemy6MovingRight = !enemy6MovingRight;

            if (label67.Bounds.IntersectsWith(enemy7.Bounds) || label15.Bounds.IntersectsWith(enemy7.Bounds))
                enemy7MovingUp = !enemy7MovingUp;

            if (label4.Bounds.IntersectsWith(enemy8.Bounds) || label13.Bounds.IntersectsWith(enemy8.Bounds))
                enemy8MovingRight = !enemy8MovingRight;
        }


        private void enemy7_Click(object sender, EventArgs e)
        {

        }
        //Обрабточик действий 2
        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            Point newPoint = new Point(this.Location.X + 25, this.Location.Y + 500);
            Cursor.Position = newPoint; 
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void label109_Click(object sender, EventArgs e)
        {

        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label97_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label85_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void label94_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void label108_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void label107_Click(object sender, EventArgs e)
        {

        }

        private void label95_Click(object sender, EventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label96_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click_2(object sender, EventArgs e)
        {
          
        }

        private void label84_Click(object sender, EventArgs e)
        {

        }
    }
}

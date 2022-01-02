namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.Label();
            this.StudentIDtextbox = new System.Windows.Forms.TextBox();
            this.SemesterTextbox = new System.Windows.Forms.TextBox();
            this.StudentInformation = new System.Windows.Forms.Label();
            this.CalculateGradeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AttendedClasses = new System.Windows.Forms.Label();
            this.AttendedClassesTextBox = new System.Windows.Forms.TextBox();
            this.Mid = new System.Windows.Forms.Label();
            this.MidTextBox = new System.Windows.Forms.TextBox();
            this.Final = new System.Windows.Forms.Label();
            this.FinalTextBox = new System.Windows.Forms.TextBox();
            this.Quiz1 = new System.Windows.Forms.Label();
            this.Quiz1TextBox = new System.Windows.Forms.TextBox();
            this.Quiz2 = new System.Windows.Forms.Label();
            this.Quiz2TextBox = new System.Windows.Forms.TextBox();
            this.Quiz3 = new System.Windows.Forms.Label();
            this.Quiz3TextBox = new System.Windows.Forms.TextBox();
            this.Quiz4 = new System.Windows.Forms.Label();
            this.Quiz4TextBox = new System.Windows.Forms.TextBox();
            this.Attendace = new System.Windows.Forms.Label();
            this.MidObtained = new System.Windows.Forms.Label();
            this.FinalObtained = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.Label();
            this.ObtainedMarks = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.lblMid = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.QuizObtained = new System.Windows.Forms.Label();
            this.lblQuiz = new System.Windows.Forms.Label();
            this.lblStatement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(91, 112);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(175, 112);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(404, 22);
            this.NameTextbox.TabIndex = 1;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(60, 169);
            this.StudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(68, 16);
            this.StudentID.TabIndex = 2;
            this.StudentID.Text = "Student ID";
            this.StudentID.Click += new System.EventHandler(this.StudentID_Click);
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(69, 226);
            this.Semester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(65, 16);
            this.Semester.TabIndex = 3;
            this.Semester.Text = "Semester";
            // 
            // StudentIDtextbox
            // 
            this.StudentIDtextbox.Location = new System.Drawing.Point(175, 165);
            this.StudentIDtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentIDtextbox.Name = "StudentIDtextbox";
            this.StudentIDtextbox.Size = new System.Drawing.Size(404, 22);
            this.StudentIDtextbox.TabIndex = 4;
            this.StudentIDtextbox.TextChanged += new System.EventHandler(this.StudentIDtextbox_TextChanged);
            // 
            // SemesterTextbox
            // 
            this.SemesterTextbox.Location = new System.Drawing.Point(175, 223);
            this.SemesterTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SemesterTextbox.Name = "SemesterTextbox";
            this.SemesterTextbox.Size = new System.Drawing.Size(404, 22);
            this.SemesterTextbox.TabIndex = 5;
            this.SemesterTextbox.TextChanged += new System.EventHandler(this.SemesterTextbox_TextChanged);
            // 
            // StudentInformation
            // 
            this.StudentInformation.AutoSize = true;
            this.StudentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInformation.Location = new System.Drawing.Point(59, 41);
            this.StudentInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentInformation.Name = "StudentInformation";
            this.StudentInformation.Size = new System.Drawing.Size(220, 29);
            this.StudentInformation.TabIndex = 6;
            this.StudentInformation.Text = "Student Information";
            // 
            // CalculateGradeButton
            // 
            this.CalculateGradeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CalculateGradeButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateGradeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CalculateGradeButton.Location = new System.Drawing.Point(675, 159);
            this.CalculateGradeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalculateGradeButton.Name = "CalculateGradeButton";
            this.CalculateGradeButton.Size = new System.Drawing.Size(129, 84);
            this.CalculateGradeButton.TabIndex = 7;
            this.CalculateGradeButton.Text = "Calculate Grade";
            this.CalculateGradeButton.UseVisualStyleBackColor = false;
            this.CalculateGradeButton.Click += new System.EventHandler(this.CalculateGradeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "SWE 4201 OOC-1 Marks";
            // 
            // AttendedClasses
            // 
            this.AttendedClasses.AutoSize = true;
            this.AttendedClasses.Location = new System.Drawing.Point(60, 416);
            this.AttendedClasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AttendedClasses.Name = "AttendedClasses";
            this.AttendedClasses.Size = new System.Drawing.Size(171, 16);
            this.AttendedClasses.TabIndex = 9;
            this.AttendedClasses.Text = "Attended classes (out of 28)";
            // 
            // AttendedClassesTextBox
            // 
            this.AttendedClassesTextBox.Location = new System.Drawing.Point(253, 412);
            this.AttendedClassesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AttendedClassesTextBox.Name = "AttendedClassesTextBox";
            this.AttendedClassesTextBox.Size = new System.Drawing.Size(125, 22);
            this.AttendedClassesTextBox.TabIndex = 10;
            this.AttendedClassesTextBox.TextChanged += new System.EventHandler(this.AttendedClassesTextBox_TextChanged);
            // 
            // Mid
            // 
            this.Mid.AutoSize = true;
            this.Mid.Location = new System.Drawing.Point(60, 468);
            this.Mid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mid.Name = "Mid";
            this.Mid.Size = new System.Drawing.Size(89, 16);
            this.Mid.TabIndex = 11;
            this.Mid.Text = "Mid (out of 75)";
            // 
            // MidTextBox
            // 
            this.MidTextBox.Location = new System.Drawing.Point(253, 464);
            this.MidTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MidTextBox.Name = "MidTextBox";
            this.MidTextBox.Size = new System.Drawing.Size(125, 22);
            this.MidTextBox.TabIndex = 12;
            this.MidTextBox.TextChanged += new System.EventHandler(this.MidTextBox_TextChanged);
            // 
            // Final
            // 
            this.Final.AutoSize = true;
            this.Final.Location = new System.Drawing.Point(60, 518);
            this.Final.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(103, 16);
            this.Final.TabIndex = 13;
            this.Final.Text = "Final (out of 150)";
            // 
            // FinalTextBox
            // 
            this.FinalTextBox.Location = new System.Drawing.Point(253, 514);
            this.FinalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FinalTextBox.Name = "FinalTextBox";
            this.FinalTextBox.Size = new System.Drawing.Size(125, 22);
            this.FinalTextBox.TabIndex = 14;
            this.FinalTextBox.TextChanged += new System.EventHandler(this.FinalTextBox_TextChanged);
            // 
            // Quiz1
            // 
            this.Quiz1.AutoSize = true;
            this.Quiz1.Location = new System.Drawing.Point(455, 412);
            this.Quiz1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz1.Name = "Quiz1";
            this.Quiz1.Size = new System.Drawing.Size(103, 16);
            this.Quiz1.TabIndex = 15;
            this.Quiz1.Text = "Quiz 1 (out of 15)";
            // 
            // Quiz1TextBox
            // 
            this.Quiz1TextBox.Location = new System.Drawing.Point(592, 407);
            this.Quiz1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quiz1TextBox.Name = "Quiz1TextBox";
            this.Quiz1TextBox.Size = new System.Drawing.Size(125, 22);
            this.Quiz1TextBox.TabIndex = 16;
            this.Quiz1TextBox.TextChanged += new System.EventHandler(this.Quiz1TextBox_TextChanged);
            // 
            // Quiz2
            // 
            this.Quiz2.AutoSize = true;
            this.Quiz2.Location = new System.Drawing.Point(455, 464);
            this.Quiz2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz2.Name = "Quiz2";
            this.Quiz2.Size = new System.Drawing.Size(103, 16);
            this.Quiz2.TabIndex = 17;
            this.Quiz2.Text = "Quiz 2 (out of 15)";
            // 
            // Quiz2TextBox
            // 
            this.Quiz2TextBox.Location = new System.Drawing.Point(592, 459);
            this.Quiz2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quiz2TextBox.Name = "Quiz2TextBox";
            this.Quiz2TextBox.Size = new System.Drawing.Size(125, 22);
            this.Quiz2TextBox.TabIndex = 18;
            this.Quiz2TextBox.TextChanged += new System.EventHandler(this.Quiz2TextBox_TextChanged);
            // 
            // Quiz3
            // 
            this.Quiz3.AutoSize = true;
            this.Quiz3.Location = new System.Drawing.Point(455, 514);
            this.Quiz3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz3.Name = "Quiz3";
            this.Quiz3.Size = new System.Drawing.Size(103, 16);
            this.Quiz3.TabIndex = 19;
            this.Quiz3.Text = "Quiz 3 (out of 15)";
            // 
            // Quiz3TextBox
            // 
            this.Quiz3TextBox.Location = new System.Drawing.Point(592, 511);
            this.Quiz3TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quiz3TextBox.Name = "Quiz3TextBox";
            this.Quiz3TextBox.Size = new System.Drawing.Size(125, 22);
            this.Quiz3TextBox.TabIndex = 20;
            this.Quiz3TextBox.TextChanged += new System.EventHandler(this.Quiz3TextBox_TextChanged);
            // 
            // Quiz4
            // 
            this.Quiz4.AutoSize = true;
            this.Quiz4.Location = new System.Drawing.Point(455, 564);
            this.Quiz4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz4.Name = "Quiz4";
            this.Quiz4.Size = new System.Drawing.Size(103, 16);
            this.Quiz4.TabIndex = 21;
            this.Quiz4.Text = "Quiz 4 (out of 15)";
            // 
            // Quiz4TextBox
            // 
            this.Quiz4TextBox.Location = new System.Drawing.Point(592, 560);
            this.Quiz4TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quiz4TextBox.Name = "Quiz4TextBox";
            this.Quiz4TextBox.Size = new System.Drawing.Size(125, 22);
            this.Quiz4TextBox.TabIndex = 22;
            this.Quiz4TextBox.TextChanged += new System.EventHandler(this.Quiz4TextBox_TextChanged);
            // 
            // Attendace
            // 
            this.Attendace.AutoSize = true;
            this.Attendace.Location = new System.Drawing.Point(936, 103);
            this.Attendace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Attendace.Name = "Attendace";
            this.Attendace.Size = new System.Drawing.Size(75, 16);
            this.Attendace.TabIndex = 23;
            this.Attendace.Text = "Attendance";
            // 
            // MidObtained
            // 
            this.MidObtained.AutoSize = true;
            this.MidObtained.Location = new System.Drawing.Point(987, 133);
            this.MidObtained.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MidObtained.Name = "MidObtained";
            this.MidObtained.Size = new System.Drawing.Size(29, 16);
            this.MidObtained.TabIndex = 24;
            this.MidObtained.Text = "Mid";
            // 
            // FinalObtained
            // 
            this.FinalObtained.AutoSize = true;
            this.FinalObtained.Location = new System.Drawing.Point(980, 196);
            this.FinalObtained.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinalObtained.Name = "FinalObtained";
            this.FinalObtained.Size = new System.Drawing.Size(36, 16);
            this.FinalObtained.TabIndex = 25;
            this.FinalObtained.Text = "Final";
            this.FinalObtained.Click += new System.EventHandler(this.FinalObtained_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(971, 262);
            this.Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(45, 17);
            this.Total.TabIndex = 26;
            this.Total.Text = "Total";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.ForeColor = System.Drawing.Color.Red;
            this.Grade.Location = new System.Drawing.Point(971, 314);
            this.Grade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(60, 20);
            this.Grade.TabIndex = 27;
            this.Grade.Text = "Grade";
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.AutoSize = true;
            this.ObtainedMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObtainedMarks.Location = new System.Drawing.Point(935, 41);
            this.ObtainedMarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ObtainedMarks.Name = "ObtainedMarks";
            this.ObtainedMarks.Size = new System.Drawing.Size(183, 29);
            this.ObtainedMarks.TabIndex = 28;
            this.ObtainedMarks.Text = "Obtained Marks";
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Location = new System.Drawing.Point(1077, 102);
            this.lblAttendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(0, 16);
            this.lblAttendance.TabIndex = 29;
            // 
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.Location = new System.Drawing.Point(1077, 133);
            this.lblMid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(0, 16);
            this.lblMid.TabIndex = 30;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(1077, 196);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(0, 16);
            this.lblFinal.TabIndex = 31;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1077, 262);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 17);
            this.lblTotal.TabIndex = 32;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.Red;
            this.lblGrade.Location = new System.Drawing.Point(1075, 314);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(0, 20);
            this.lblGrade.TabIndex = 33;
            // 
            // QuizObtained
            // 
            this.QuizObtained.AutoSize = true;
            this.QuizObtained.Location = new System.Drawing.Point(980, 165);
            this.QuizObtained.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuizObtained.Name = "QuizObtained";
            this.QuizObtained.Size = new System.Drawing.Size(33, 16);
            this.QuizObtained.TabIndex = 34;
            this.QuizObtained.Text = "Quiz";
            // 
            // lblQuiz
            // 
            this.lblQuiz.AutoSize = true;
            this.lblQuiz.Location = new System.Drawing.Point(1077, 165);
            this.lblQuiz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuiz.Name = "lblQuiz";
            this.lblQuiz.Size = new System.Drawing.Size(0, 16);
            this.lblQuiz.TabIndex = 35;
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Location = new System.Drawing.Point(971, 364);
            this.lblStatement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(0, 16);
            this.lblStatement.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 802);
            this.Controls.Add(this.lblStatement);
            this.Controls.Add(this.lblQuiz);
            this.Controls.Add(this.QuizObtained);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblMid);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.ObtainedMarks);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.FinalObtained);
            this.Controls.Add(this.MidObtained);
            this.Controls.Add(this.Attendace);
            this.Controls.Add(this.Quiz4TextBox);
            this.Controls.Add(this.Quiz4);
            this.Controls.Add(this.Quiz3TextBox);
            this.Controls.Add(this.Quiz3);
            this.Controls.Add(this.Quiz2TextBox);
            this.Controls.Add(this.Quiz2);
            this.Controls.Add(this.Quiz1TextBox);
            this.Controls.Add(this.Quiz1);
            this.Controls.Add(this.FinalTextBox);
            this.Controls.Add(this.Final);
            this.Controls.Add(this.MidTextBox);
            this.Controls.Add(this.Mid);
            this.Controls.Add(this.AttendedClassesTextBox);
            this.Controls.Add(this.AttendedClasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateGradeButton);
            this.Controls.Add(this.StudentInformation);
            this.Controls.Add(this.SemesterTextbox);
            this.Controls.Add(this.StudentIDtextbox);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;

            this.Text = "GradeApp";
            this.Load += new System.EventHandler(this.GradeApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.TextBox StudentIDtextbox;
        private System.Windows.Forms.TextBox SemesterTextbox;
        private System.Windows.Forms.Label StudentInformation;
        private System.Windows.Forms.Button CalculateGradeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AttendedClasses;
        private System.Windows.Forms.TextBox AttendedClassesTextBox;
        private System.Windows.Forms.Label Mid;
        private System.Windows.Forms.TextBox MidTextBox;
        private System.Windows.Forms.Label Final;
        private System.Windows.Forms.TextBox FinalTextBox;
        private System.Windows.Forms.Label Quiz1;
        private System.Windows.Forms.TextBox Quiz1TextBox;
        private System.Windows.Forms.Label Quiz2;
        private System.Windows.Forms.TextBox Quiz2TextBox;
        private System.Windows.Forms.Label Quiz3;
        private System.Windows.Forms.TextBox Quiz3TextBox;
        private System.Windows.Forms.Label Quiz4;
        private System.Windows.Forms.TextBox Quiz4TextBox;
        private System.Windows.Forms.Label Attendace;
        private System.Windows.Forms.Label MidObtained;
        private System.Windows.Forms.Label FinalObtained;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Label ObtainedMarks;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label lblMid;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label QuizObtained;
        private System.Windows.Forms.Label lblQuiz;
        private System.Windows.Forms.Label lblStatement;
    }
}


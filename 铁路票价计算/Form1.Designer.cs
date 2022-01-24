namespace 铁路票价计算
{
    partial class Frame
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMileage = new System.Windows.Forms.Label();
            this.mileage = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.labelStudy = new System.Windows.Forms.Label();
            this.getRes = new System.Windows.Forms.Button();
            this.ordinaryType = new System.Windows.Forms.RadioButton();
            this.fastType = new System.Windows.Forms.RadioButton();
            this.expressTpye = new System.Windows.Forms.RadioButton();
            this.hardSeatType = new System.Windows.Forms.RadioButton();
            this.hardSleepType = new System.Windows.Forms.RadioButton();
            this.softSleepType = new System.Windows.Forms.RadioButton();
            this.yesStudy = new System.Windows.Forms.RadioButton();
            this.noStudy = new System.Windows.Forms.RadioButton();
            this.trainType = new System.Windows.Forms.GroupBox();
            this.StudyType = new System.Windows.Forms.GroupBox();
            this.seatType = new System.Windows.Forms.GroupBox();
            this.labelAir = new System.Windows.Forms.Label();
            this.airType = new System.Windows.Forms.GroupBox();
            this.yesAir = new System.Windows.Forms.RadioButton();
            this.noAir = new System.Windows.Forms.RadioButton();
            this.trainType.SuspendLayout();
            this.StudyType.SuspendLayout();
            this.seatType.SuspendLayout();
            this.airType.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMileage
            // 
            this.labelMileage.AutoSize = true;
            this.labelMileage.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMileage.Location = new System.Drawing.Point(84, 59);
            this.labelMileage.Name = "labelMileage";
            this.labelMileage.Size = new System.Drawing.Size(130, 23);
            this.labelMileage.TabIndex = 0;
            this.labelMileage.Text = "输入里程：";
            // 
            // mileage
            // 
            this.mileage.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mileage.Location = new System.Drawing.Point(201, 59);
            this.mileage.Name = "mileage";
            this.mileage.Size = new System.Drawing.Size(446, 30);
            this.mileage.TabIndex = 1;
            this.mileage.TextChanged += new System.EventHandler(this.mileage_TextChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelType.Location = new System.Drawing.Point(84, 135);
            this.labelType.Name = "labelType";
            this.labelType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelType.Size = new System.Drawing.Size(130, 23);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "列车类型：";
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSeat.Location = new System.Drawing.Point(84, 199);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSeat.Size = new System.Drawing.Size(130, 23);
            this.labelSeat.TabIndex = 3;
            this.labelSeat.Text = "座位类型：";
            // 
            // labelStudy
            // 
            this.labelStudy.AutoSize = true;
            this.labelStudy.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStudy.Location = new System.Drawing.Point(84, 322);
            this.labelStudy.Name = "labelStudy";
            this.labelStudy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStudy.Size = new System.Drawing.Size(154, 23);
            this.labelStudy.TabIndex = 4;
            this.labelStudy.Text = "是否学生票：";
            this.labelStudy.Click += new System.EventHandler(this.label1_Click);
            // 
            // getRes
            // 
            this.getRes.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getRes.Location = new System.Drawing.Point(539, 371);
            this.getRes.Name = "getRes";
            this.getRes.Size = new System.Drawing.Size(108, 41);
            this.getRes.TabIndex = 5;
            this.getRes.Text = "计算";
            this.getRes.UseVisualStyleBackColor = true;
            this.getRes.Click += new System.EventHandler(this.getRes_Click);
            // 
            // ordinaryType
            // 
            this.ordinaryType.AutoSize = true;
            this.ordinaryType.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ordinaryType.Location = new System.Drawing.Point(6, 15);
            this.ordinaryType.Name = "ordinaryType";
            this.ordinaryType.Size = new System.Drawing.Size(110, 24);
            this.ordinaryType.TabIndex = 6;
            this.ordinaryType.TabStop = true;
            this.ordinaryType.Tag = "";
            this.ordinaryType.Text = "普通列车";
            this.ordinaryType.UseVisualStyleBackColor = true;
            this.ordinaryType.CheckedChanged += new System.EventHandler(this.ordinaryType_CheckedChanged);
            // 
            // fastType
            // 
            this.fastType.AutoSize = true;
            this.fastType.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fastType.Location = new System.Drawing.Point(165, 15);
            this.fastType.Name = "fastType";
            this.fastType.Size = new System.Drawing.Size(110, 24);
            this.fastType.TabIndex = 7;
            this.fastType.TabStop = true;
            this.fastType.Text = "快速列车";
            this.fastType.UseVisualStyleBackColor = true;
            // 
            // expressTpye
            // 
            this.expressTpye.AutoSize = true;
            this.expressTpye.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.expressTpye.Location = new System.Drawing.Point(322, 15);
            this.expressTpye.Name = "expressTpye";
            this.expressTpye.Size = new System.Drawing.Size(110, 24);
            this.expressTpye.TabIndex = 8;
            this.expressTpye.TabStop = true;
            this.expressTpye.Text = "特快列车";
            this.expressTpye.UseVisualStyleBackColor = true;
            // 
            // hardSeatType
            // 
            this.hardSeatType.AutoSize = true;
            this.hardSeatType.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hardSeatType.Location = new System.Drawing.Point(6, 18);
            this.hardSeatType.Name = "hardSeatType";
            this.hardSeatType.Size = new System.Drawing.Size(70, 24);
            this.hardSeatType.TabIndex = 9;
            this.hardSeatType.TabStop = true;
            this.hardSeatType.Text = "硬座";
            this.hardSeatType.UseVisualStyleBackColor = true;
            // 
            // hardSleepType
            // 
            this.hardSleepType.AutoSize = true;
            this.hardSleepType.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hardSleepType.Location = new System.Drawing.Point(161, 20);
            this.hardSleepType.Name = "hardSleepType";
            this.hardSleepType.Size = new System.Drawing.Size(70, 24);
            this.hardSleepType.TabIndex = 10;
            this.hardSleepType.TabStop = true;
            this.hardSleepType.Text = "硬卧";
            this.hardSleepType.UseVisualStyleBackColor = true;
            // 
            // softSleepType
            // 
            this.softSleepType.AutoSize = true;
            this.softSleepType.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.softSleepType.Location = new System.Drawing.Point(318, 18);
            this.softSleepType.Name = "softSleepType";
            this.softSleepType.Size = new System.Drawing.Size(70, 24);
            this.softSleepType.TabIndex = 11;
            this.softSleepType.TabStop = true;
            this.softSleepType.Text = "软卧";
            this.softSleepType.UseVisualStyleBackColor = true;
            // 
            // yesStudy
            // 
            this.yesStudy.AutoSize = true;
            this.yesStudy.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yesStudy.Location = new System.Drawing.Point(90, 18);
            this.yesStudy.Name = "yesStudy";
            this.yesStudy.Size = new System.Drawing.Size(50, 24);
            this.yesStudy.TabIndex = 14;
            this.yesStudy.TabStop = true;
            this.yesStudy.Text = "是";
            this.yesStudy.UseVisualStyleBackColor = true;
            // 
            // noStudy
            // 
            this.noStudy.AutoSize = true;
            this.noStudy.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noStudy.Location = new System.Drawing.Point(282, 18);
            this.noStudy.Name = "noStudy";
            this.noStudy.Size = new System.Drawing.Size(50, 24);
            this.noStudy.TabIndex = 15;
            this.noStudy.TabStop = true;
            this.noStudy.Text = "否";
            this.noStudy.UseVisualStyleBackColor = true;
            // 
            // trainType
            // 
            this.trainType.Controls.Add(this.ordinaryType);
            this.trainType.Controls.Add(this.fastType);
            this.trainType.Controls.Add(this.expressTpye);
            this.trainType.Location = new System.Drawing.Point(199, 121);
            this.trainType.Name = "trainType";
            this.trainType.Size = new System.Drawing.Size(447, 53);
            this.trainType.TabIndex = 16;
            this.trainType.TabStop = false;
            // 
            // StudyType
            // 
            this.StudyType.Controls.Add(this.yesStudy);
            this.StudyType.Controls.Add(this.noStudy);
            this.StudyType.Location = new System.Drawing.Point(228, 304);
            this.StudyType.Name = "StudyType";
            this.StudyType.Size = new System.Drawing.Size(418, 50);
            this.StudyType.TabIndex = 17;
            this.StudyType.TabStop = false;
            // 
            // seatType
            // 
            this.seatType.Controls.Add(this.hardSeatType);
            this.seatType.Controls.Add(this.hardSleepType);
            this.seatType.Controls.Add(this.softSleepType);
            this.seatType.Location = new System.Drawing.Point(203, 180);
            this.seatType.Name = "seatType";
            this.seatType.Size = new System.Drawing.Size(442, 52);
            this.seatType.TabIndex = 18;
            this.seatType.TabStop = false;
            // 
            // labelAir
            // 
            this.labelAir.AutoSize = true;
            this.labelAir.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAir.Location = new System.Drawing.Point(84, 265);
            this.labelAir.Name = "labelAir";
            this.labelAir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAir.Size = new System.Drawing.Size(178, 23);
            this.labelAir.TabIndex = 19;
            this.labelAir.Text = "是否空调列车：";
            // 
            // airType
            // 
            this.airType.Controls.Add(this.yesAir);
            this.airType.Controls.Add(this.noAir);
            this.airType.Location = new System.Drawing.Point(250, 248);
            this.airType.Name = "airType";
            this.airType.Size = new System.Drawing.Size(397, 50);
            this.airType.TabIndex = 20;
            this.airType.TabStop = false;
            // 
            // yesAir
            // 
            this.yesAir.AutoSize = true;
            this.yesAir.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yesAir.Location = new System.Drawing.Point(68, 18);
            this.yesAir.Name = "yesAir";
            this.yesAir.Size = new System.Drawing.Size(50, 24);
            this.yesAir.TabIndex = 14;
            this.yesAir.TabStop = true;
            this.yesAir.Text = "是";
            this.yesAir.UseVisualStyleBackColor = true;
            // 
            // noAir
            // 
            this.noAir.AutoSize = true;
            this.noAir.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noAir.Location = new System.Drawing.Point(260, 18);
            this.noAir.Name = "noAir";
            this.noAir.Size = new System.Drawing.Size(50, 24);
            this.noAir.TabIndex = 15;
            this.noAir.TabStop = true;
            this.noAir.Text = "否";
            this.noAir.UseVisualStyleBackColor = true;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.airType);
            this.Controls.Add(this.labelAir);
            this.Controls.Add(this.seatType);
            this.Controls.Add(this.StudyType);
            this.Controls.Add(this.trainType);
            this.Controls.Add(this.getRes);
            this.Controls.Add(this.labelStudy);
            this.Controls.Add(this.labelSeat);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.mileage);
            this.Controls.Add(this.labelMileage);
            this.Name = "Frame";
            this.Text = "铁路票价计算";
            this.trainType.ResumeLayout(false);
            this.trainType.PerformLayout();
            this.StudyType.ResumeLayout(false);
            this.StudyType.PerformLayout();
            this.seatType.ResumeLayout(false);
            this.seatType.PerformLayout();
            this.airType.ResumeLayout(false);
            this.airType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMileage;
        private System.Windows.Forms.TextBox mileage;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.Label labelStudy;
        private System.Windows.Forms.Button getRes;
        private System.Windows.Forms.RadioButton ordinaryType;
        private System.Windows.Forms.RadioButton fastType;
        private System.Windows.Forms.RadioButton expressTpye;
        private System.Windows.Forms.RadioButton hardSeatType;
        private System.Windows.Forms.RadioButton hardSleepType;
        private System.Windows.Forms.RadioButton softSleepType;
        private System.Windows.Forms.RadioButton yesStudy;
        private System.Windows.Forms.RadioButton noStudy;
        private System.Windows.Forms.GroupBox trainType;
        private System.Windows.Forms.GroupBox StudyType;
        private System.Windows.Forms.GroupBox seatType;
        private System.Windows.Forms.Label labelAir;
        private System.Windows.Forms.GroupBox airType;
        private System.Windows.Forms.RadioButton yesAir;
        private System.Windows.Forms.RadioButton noAir;
    }
}


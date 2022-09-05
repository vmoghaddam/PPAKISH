﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace Report
{
    public partial class rptAtt : DevExpress.XtraReports.UI.XtraReport
    {
        public rptAtt(string _cid)
        {
            InitializeComponent();
             
            int cid = Convert.ToInt32(_cid);
            var context = new ppa_cspnEntities();
            
            var course = context.ViewCourseNews.Where(q => q.Id == cid).FirstOrDefault();



            cellDir.Text = course.TrainingDirector;
            List<string> insts = new List<string>();
            if (!string.IsNullOrEmpty(course.Instructor))
                insts.Add(course.Instructor);
            if (!string.IsNullOrEmpty(course.Instructor2))
                insts.Add(course.Instructor2);
            cellIns.Text = string.Join(", ", insts);
            lblTitle.Text = course.Title;
            lblType.Text = course.CourseType;
            lblClassID.Text = course.No;
            lblInstructor.Text = course.Instructor;
            lblLocation.Text = course.Location;
            lblDuration.Text = course.Duration + " (hrs)";
            lblStart.Text = course.DateStart.ToString("yyyy-MM-dd");
            lblEnd.Text = ((DateTime)course.DateEnd).ToString("yyyy-MM-dd");

            var query = context.ViewCoursePeoples.Where(q => q.CourseId == cid).OrderBy(q => q.LastName).ToList();
            var sessions = context.ViewCourseSessions.Where(q => q.CourseId == cid).OrderBy(q => q.DateStart).ToList();
            var atts = context.ViewCourseSessionPresences.Where(q => q.CourseId == cid).ToList();
            var ds = (from x in query
                      select new PersonAtt()
                      {
                          FullName = x.Name,
                          NID = x.NID,
                          Result = x.CoursePeopleStatus == "UNKNOWN" ? "" : x.CoursePeopleStatus.Substring(0, 1).ToUpper(),
                          Department = x.EmployeeLocation,
                          PersonId = (int)x.PersonId,

                      }).ToList();
            var c = 1;
            foreach (var emp in ds)
            {
                var empatts = atts.Where(q => q.PersonId == emp.PersonId).ToList();
                int k = 1;
                foreach (var se in sessions)
                {
                    var empse = empatts.FirstOrDefault(q => q.PersonId == emp.PersonId && q.SessionKey == se.Key);
                    if (empse != null && empse.IsPresent == 1)
                    {
                        switch (k)
                        {
                            case 1:
                                emp.S01 = "✓";
                                break;
                            case 2:
                                emp.S02 = "✓";
                                break;
                            case 3:
                                emp.S03 = "✓";
                                break;
                            case 4:
                                emp.S04 = "✓";
                                break;
                            case 5:
                                emp.S05 = "✓";
                                break;
                            default:
                                break;
                        }
                    }
                    k++;
                }
                emp.No = c.ToString();
                c++;
            }


            var sessionsCount = sessions.Count;
            xrTable1.BeginInit();
            xrTable2.BeginInit();

            switch (sessionsCount)
            {
                case 1:
                    cellSe01.Visible = true;
                    cellSe01.Text = ((DateTime)sessions[0].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                     + ((DateTime)sessions[0].DateEnd).ToString("HH:mm");

                    s1r1s.Visible = true;



                    xrTable1.Rows[0].DeleteCell(cellSe02);
                    xrTable2.Rows[0].DeleteCell(s2r1s);



                    xrTable1.Rows[0].DeleteCell(cellSe03);
                    xrTable2.Rows[0].DeleteCell(s3r1s);



                    xrTable1.Rows[0].DeleteCell(cellSe04);
                    xrTable2.Rows[0].DeleteCell(s4r1s);




                    xrTable1.Rows[0].DeleteCell(cellSe05);
                    xrTable2.Rows[0].DeleteCell(s5r1s);



                    break;
                case 2:
                    cellSe01.Visible = true;
                    cellSe01.Text = ((DateTime)sessions[0].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                     + ((DateTime)sessions[0].DateEnd).ToString("HH:mm");
                    s1r1s.Visible = true;


                    cellSe02.Visible = true;
                    cellSe02.Text = ((DateTime)sessions[1].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                     + ((DateTime)sessions[1].DateEnd).ToString("HH:mm");

                    s2r1s.Visible = true;


                    xrTable1.Rows[0].DeleteCell(cellSe03);
                    xrTable2.Rows[0].DeleteCell(s3r1s);




                    xrTable1.Rows[0].DeleteCell(cellSe04);
                    xrTable2.Rows[0].DeleteCell(s4r1s);




                    xrTable1.Rows[0].DeleteCell(cellSe05);
                    xrTable2.Rows[0].DeleteCell(s5r1s);




                    break;
                case 3:
                    cellSe01.Visible = true;
                    cellSe01.Text = ((DateTime)sessions[0].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                     + ((DateTime)sessions[0].DateEnd).ToString("HH:mm");

                    s1r1s.Visible = true;


                    cellSe02.Visible = true;
                    cellSe02.Text = ((DateTime)sessions[1].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                     + ((DateTime)sessions[1].DateEnd).ToString("HH:mm");

                    s2r1s.Visible = true;


                    cellSe03.Visible = true;
                    cellSe03.Text = ((DateTime)sessions[2].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                     + ((DateTime)sessions[2].DateEnd).ToString("HH:mm");

                    s3r1s.Visible = true;



                    xrTable1.Rows[0].DeleteCell(cellSe04);
                    xrTable2.Rows[0].DeleteCell(s4r1s);




                    xrTable1.Rows[0].DeleteCell(cellSe05);
                    xrTable2.Rows[0].DeleteCell(s5r1s);




                    break;
                case 4:
                    cellSe01.Visible = true;
                    cellSe01.Text = ((DateTime)sessions[0].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                     + ((DateTime)sessions[0].DateEnd).ToString("HH:mm");

                    s1r1s.Visible = true;

                    cellSe02.Visible = true;
                    cellSe02.Text = ((DateTime)sessions[1].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                     + ((DateTime)sessions[1].DateEnd).ToString("HH:mm");

                    s2r1s.Visible = true;


                    cellSe03.Visible = true;
                    cellSe03.Text = ((DateTime)sessions[2].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                     + ((DateTime)sessions[2].DateEnd).ToString("HH:mm");

                    s3r1s.Visible = true;


                    cellSe04.Visible = true;
                    cellSe04.Text = ((DateTime)sessions[3].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                     + ((DateTime)sessions[3].DateEnd).ToString("HH:mm");

                    s4r1s.Visible = true;


                    xrTable1.Rows[0].DeleteCell(cellSe05);

                    xrTable2.Rows[0].DeleteCell(s5r1s);







                    break;

                case 5:
                    cellSe01.Text = ((DateTime)sessions[0].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                        + ((DateTime)sessions[0].DateEnd).ToString("HH:mm");

                    cellSe01.Visible = true;

                    s1r1s.Visible = true;


                    cellSe02.Visible = true;
                    cellSe02.Text = ((DateTime)sessions[1].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                       + ((DateTime)sessions[1].DateEnd).ToString("HH:mm");

                    s2r1s.Visible = true;


                    cellSe03.Visible = true;
                    cellSe03.Text = ((DateTime)sessions[2].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                       + ((DateTime)sessions[2].DateEnd).ToString("HH:mm");

                    s3r1s.Visible = true;


                    cellSe04.Visible = true;
                    cellSe04.Text = ((DateTime)sessions[3].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                       + ((DateTime)sessions[3].DateEnd).ToString("HH:mm");

                    s4r1s.Visible = true;


                    cellSe05.Visible = true;
                    cellSe05.Text = ((DateTime)sessions[4].DateStart).ToString("yyyy-MM-dd HH:mm - ")
                       + ((DateTime)sessions[4].DateEnd).ToString("HH:mm");

                    s5r1s.Visible = true;


                    break;
                default:
                    break;
            }
            var _w = this.PageWidth - this.Margins.Left - this.Margins.Right;

            hFullName.WidthF = _w - sessionsCount * 90 - (hNo.WidthF + hNID.WidthF + hDep.WidthF + hResult.WidthF + hSig.WidthF);
            cFullName.WidthF = _w - sessionsCount * 90 - (hNo.WidthF + hNID.WidthF + hDep.WidthF + hResult.WidthF + hSig.WidthF);
            //  xrTableCell46.WidthF = _w - sessionsCount * 90 - (hNo.WidthF + hNID.WidthF + hDep.WidthF + hResult.WidthF + hSig.WidthF);



            xrTable1.EndInit();
            xrTable2.EndInit();


            // cFullName.WidthF = _w - sessionsCount * 90;
            //xrTableCell46.WidthF = _w - sessionsCount * 90;
            this.DataSource = ds;

        }

        private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //e.Cancel = true;
        }
    }

    public class PersonAtt
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string NID { get; set; }
        public string No { get; set; }
        public string Department { get; set; }
        public string Result { get; set; }

        public string S01Start { get; set; }
        public string S02Start { get; set; }
        public string S03Start { get; set; }
        public string S04Start { get; set; }

        public string S01End { get; set; }
        public string S02End { get; set; }
        public string S03End { get; set; }
        public string S04End { get; set; }

        public string S01 { get; set; }
        public string S02 { get; set; }
        public string S03 { get; set; }
        public string S04 { get; set; }
        public string S05 { get; set; }




    }
}

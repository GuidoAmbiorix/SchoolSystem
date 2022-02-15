using SchoolSystem.Models;
using SchoolSystem.Models.JoinTables;

namespace SchoolSystem.Data
{
    public class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
         {
             using (var servicesScope = applicationBuilder.ApplicationServices.CreateScope())
             {
                 var context = servicesScope.ServiceProvider.GetService<ApplicationDbContext>();

                 context.Database.EnsureCreated();


                //Career
                if (!context.Careers.Any())
                {
                    context.AddRange(new List<Career>()
                            {
                                new Career()
                                {
                                    Career_Name="Systems engineer",
                                    Career_Duration="4 years"
                                },
                                new Career()
                                {
                                    Career_Name="sightseeing",
                                    Career_Duration="4 years"
                                },
                                new Career()
                                {
                                    Career_Name="Medicine",
                                    Career_Duration="10 years"
                                },
                                   new Career()
                                {
                                    Career_Name="International relations",
                                    Career_Duration="4 years"
                                }
                            });
                    context.SaveChanges();
                }

                //Courses
                if (!context.Courses.Any())
                {
                    context.AddRange(new List<Course>()
                                {
                                    new Course()
                                    {
                                        Course_Name="Computing 1",
                                        Course_Credits=4
                                    },
                                     new Course()
                                    {
                                        Course_Name="University Orientation",
                                        Course_Credits=3
                                    },
                                      new Course()
                                    {
                                        Course_Name="Environmental management",
                                        Course_Credits=3
                                    },
                                       new Course()
                                    {
                                        Course_Name="Math 1",
                                        Course_Credits=5
                                    }

                                });
                    context.SaveChanges();
                }


                //Teachers
                if (!context.Teachers.Any())
                {
                    context.AddRange(new List<Teacher>()
                        {
                            new Teacher()
                            {
                                Teacher_Name="Rafael Robles",
                                Teacher_Direction="Calle 2",
                                Teacher_Phone="846-5465-46346",
                                Teacher_Horary="8-10 , Monday"
                            },
                            new Teacher()
                            {
                                Teacher_Name="Guillermo Marco",
                                Teacher_Direction="Calle 3",
                                Teacher_Phone="846-5465-47346",
                                Teacher_Horary="6-8 , Monday"
                            },
                            new Teacher()
                            {
                                Teacher_Name="Clara Sendra",
                                Teacher_Direction="Calle 4",
                                Teacher_Phone="846-5465-49346",
                                Teacher_Horary="3-5 , Tuesday"
                            },
                            new Teacher()
                            {
                                Teacher_Name="Liliana Fallas",
                                Teacher_Direction="Calle 5",
                                Teacher_Phone="846-5465-49346",
                                Teacher_Horary="8-10 , Sunday"
                            }

                        });
                    context.SaveChanges();
                }

                //Student
                if (!context.Students.Any())
                {
                    context.AddRange(new List<Student>()
                    {
                        new Student()
                        {
                            Student_Name="Guido Amparo",
                            Student_Age=22,
                            Student_Semester=1,
                            Student_Gender = Enums.StudentGender.Male,
                            CareerId=1
                            
                        },
                        new Student()
                        {
                            Student_Name="Eduardo Rios",
                            Student_Age=19,
                            Student_Semester=2,
                            Student_Gender = Enums.StudentGender.Male,
                             CareerId=2
                        },
                        new Student()
                        {
                            Student_Name="Paulo Marcos",
                            Student_Age=18,
                            Student_Semester=3,
                            Student_Gender = Enums.StudentGender.Male,
                             CareerId=3
                        },
                        new Student()
                        {
                            Student_Name="Ramon Fernandez",
                            Student_Age=19,
                            Student_Semester=4,
                            Student_Gender = Enums.StudentGender.Male,
                             CareerId=4
                        },
                        new Student()
                        {
                            Student_Name="Raquel Rosanna",
                            Student_Age=19,
                            Student_Semester=5,
                            Student_Gender = Enums.StudentGender.Female,
                             CareerId=1
                        },
                        new Student()
                        {
                            Student_Name="Juan Sanchez",
                            Student_Age=22,
                            Student_Semester=6,
                            Student_Gender = Enums.StudentGender.Male,
                             CareerId=2
                        },
                       new Student()
                        {
                            Student_Name="Marcela Moira",
                            Student_Age=22,
                            Student_Semester=7,
                            Student_Gender = Enums.StudentGender.Female,
                             CareerId=3
                        },
                       new Student()
                        {
                           Student_Name="Tereza Ruiz",
                            Student_Age=22,
                            Student_Semester=8,
                            Student_Gender = Enums.StudentGender.Female,
                            CareerId=4
                        }

                    });
                    context.SaveChanges();
                }


                //Teachers & Courses
                if (!context.Teacher_Courses.Any())
                {
                    context.Teacher_Courses.AddRange(new List<TeacherCourse>()
                    {
                        new TeacherCourse()
                        {
                            CourseId=1,
                            TeacherId=1
                        },
                        new TeacherCourse()
                        {
                            CourseId=2,
                            TeacherId=2
                        },
                        new TeacherCourse()
                        {
                            CourseId=3,
                            TeacherId=3
                        },
                        new TeacherCourse()
                        {
                            CourseId=4,
                            TeacherId=4
                        }

                    });
                    context.SaveChanges();
                }

                //Students & Teachers
                if (!context.Student_Teachers.Any())
                {
                    context.Student_Teachers.AddRange(new List<StudentTeacher>()
                    {
                        new StudentTeacher()
                        {
                            TeacherId=1,
                            StudentId=1
                            
                        },

                        new StudentTeacher()
                        {
                            TeacherId=2,
                            StudentId=2
                        },

                        new StudentTeacher()
                        {
                            TeacherId=3,
                            StudentId=3
                        },

                        new StudentTeacher()
                        {
                            TeacherId=4,
                            StudentId=4
                        },

                        new StudentTeacher()
                        {
                            TeacherId=1,
                            StudentId=5
                        },

                        new StudentTeacher()
                        {
                            TeacherId=2,
                            StudentId=6
                        },

                        new StudentTeacher()
                        {
                            TeacherId=3,
                            StudentId=7
                        },

                        new StudentTeacher()
                        {
                            TeacherId=4,
                            StudentId=8
                        }

                    });
                    context.SaveChanges();
                }

                //Students & Courses
                if (!context.Student_Courses.Any())
                {
                    context.Student_Courses.AddRange(new List<StudentCourse>()
                    {
                        new StudentCourse()
                        {
                            CourseId=1,
                           StudentId=1
                        },
                        new StudentCourse()
                        {
                            CourseId=2,
                            StudentId=2
                        },
                        new StudentCourse()
                        {
                            CourseId=3,
                            StudentId=3
                        },
                        new StudentCourse()
                        {
                            CourseId=4,
                            StudentId=4
                        },
                        new StudentCourse()
                        {
                            CourseId=1,
                            StudentId=5
                        },
                        new StudentCourse()
                        {
                            CourseId=2,
                            StudentId=6
                        },
                        new StudentCourse()
                        {
                            CourseId=3,
                            StudentId=7
                        },
                        new StudentCourse()
                        {
                            CourseId=4,
                            StudentId=8
                        }

                    });
                    context.SaveChanges();
                }

                

              
            }
                     }
                 }
             }
         
    


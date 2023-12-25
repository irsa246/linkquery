using Microsoft.EntityFrameworkCore;

namespace linkquery.Data
{
    public class LINQ
    {
        private readonly WebDbContext _Db;
        public LINQ(WebDbContext Db)
        {
            _Db = Db;

        }
        // Now Let's perform CRUD for Student Class

        // Get the Record of Students
        public async Task<List<Student>> GetStudents()
        {
            return await _Db.Students.ToListAsync();
        }
        //Add new Student
        public async Task<bool> AddStudent(Student std)
        {
            await _Db.Students.AddAsync(std);
            await _Db.SaveChangesAsync();
            return true;

        }
        // Search Student By Id
        public async Task<Student> SearchStudent(int id)
        {
            Student std = await _Db.Students.FirstOrDefaultAsync(x => x.S_id == id);
            return std;

        }
        // Update Student By Id
        public async Task<bool> UpdateStudent(Student std)
        {
            _Db.Students.Update(std);
            await _Db.SaveChangesAsync();
            return true;

        }
        // Delete Student By Id
        public async Task<bool> DeleteStudent(Student std)
        {
            _Db.Students.Remove(std);
            await _Db.SaveChangesAsync();
            return true;

        }



    }
}

   
    

        
       
      

    


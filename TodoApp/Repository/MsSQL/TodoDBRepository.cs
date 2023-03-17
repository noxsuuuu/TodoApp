using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Repository.MsSQL
{
    public class TodoDBRepository : ITodoRepository
    {

        TodoDbContext _dbContext;


        public TodoDBRepository(TodoDbContext dbContext)
        {
            _dbContext = dbContext;

        }


        public Todo AddTodo(Todo newTodo)
        {
             _dbContext.Add(newTodo);
             _dbContext.SaveChanges();

            return newTodo;
            
        }

        public Todo DeleteTodo(int todoId)
        {
            var todo = GetTodoById(todoId);

            if(todo != null)
            { 
                _dbContext.Todos.Remove(todo);
                _dbContext.SaveChanges();
            }
            return todo;
        }

        public List<Todo> GetAllTodos()
        {

           return _dbContext.Todos.ToList<Todo>();
        }

        public Todo GetTodoById(int Id)
        {
            return _dbContext.Todos.AsNoTracking().FirstOrDefault(t => t.Id == Id);
        }

        public Todo UpdateTodo(int todoId, Todo newTodo)
        {


            var oldTodo= GetTodoById(todoId);

            if(oldTodo != null) {

             
            _dbContext.Todos.Update(newTodo);
            _dbContext.SaveChanges();
            }
            return oldTodo;
        }
    }
}

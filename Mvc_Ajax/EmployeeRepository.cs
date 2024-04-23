namespace Mvc_Ajax
{
    public class EmployeeRepository
    {
        private readonly Context context;

        public EmployeeRepository(Context context)
        {
            this.context = context;
        }

        public object GetUserDetails()
        {
            var data = context.Employees.ToList();

            if (data == null)
            {
                return null;
            }
            return data;
        }
    }
}

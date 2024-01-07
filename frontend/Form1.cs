namespace frontend
{
    public partial class Form1 : Form
    {
        EmployeeService employeeService;
        DepartmentService departmentService;
        List<Employee> employeeList;
        List<Department> departmentList;
        public Form1()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            employeeService.createConnection();
            departmentService = new DepartmentService();
            departmentService.createDepartmentConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var employeeList = employeeService.getEmployees();
            foreach (Employee employee in employeeList)
            {
                listBox1.Items.Add(employee.name);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int departId = Int32.Parse(textBox1.Text);
            var employeeList = employeeService.getEmployeesByDepartmentId(departId);
            foreach (Employee employee in employeeList)
            {
                listBox1.Items.Add(employee.name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int departId = Int32.Parse(textBox1.Text);
            Department department = new Department();
            department.id = departId;
            departmentService.deleteDepartment(department);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int departId = Int32.Parse(textBox1.Text);
            string departDescription = textBox2.Text;
            int departParentId = Int32.Parse(textBox3.Text);
            Department department = new Department();
            department.id = departId;
            department.description = departDescription;
            department.parentId = departParentId;
            departmentService.addDepartment(department);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int departId = Int32.Parse(textBox1.Text);
            string departDescription = textBox2.Text;
            int departParentId = Int32.Parse(textBox3.Text);
            Department department = new Department();
            department.id = departId;
            department.description = departDescription;
            department.parentId = departParentId;
            departmentService.updateDepartment(department);

        }
    }
}
using CSharpStudy.NewGrammer;

// 全局using【定义GlobalUsing.cs】
string extension= Path.GetExtension("123.abc");
Console.WriteLine(extension);

Student student = new Student();
student.Name = "张三";
student.Address = "青岛";
// 使用!抑制警告
Console.WriteLine(student!.Address);


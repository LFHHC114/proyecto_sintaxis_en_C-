using System;

class Program
{
    static void Main()
    {
        ShowMainMenu();
    }

    
    // MENÚ PRINCIPAL

    static void ShowMainMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== SISTEMA DE BIBLIOTECA ===");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    ShowBooksMenu();
                    break;

                case 2:
                    ShowUsersMenu();
                    break;

                case 3:
                    ShowLoansMenu();
                    break;

                case 4:
                    ShowSearchReportsMenu();
                    break;

                case 5:
                    ShowPersistenceMenu();
                    break;

                case 6:
                    ConfirmExitAndSave();
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 6);
    }

    // MENÚ LIBROS

    static void ShowBooksMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ LIBROS ===");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("0. Volver");
            Console.Write("Seleccione: ");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    RegisterBook();
                    break;

                case 2:
                    ListBooksMenu();
                    break;

                case 3:
                    ViewBookDetail();
                    break;

                case 4:
                    UpdateBookMenu();
                    break;

                case 5:
                    DeleteBook();
                    break;
            }

        } while (opcion != 0);
    }

    static void RegisterBook()
    {
        Console.WriteLine("Función: Registrar libro en el sistema.");
    }

    static void ListBooksMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== LISTAR LIBROS ===");
            Console.WriteLine("1. Listar todos");
            Console.WriteLine("2. Listar disponibles");
            Console.WriteLine("3. Listar prestados");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    ListBooksAll();
                    break;

                case 2:
                    ListBooksAvailable();
                    break;

                case 3:
                    ListBooksBorrowed();
                    break;
            }

        } while (opcion != 0);
    }

    static void ListBooksAll()
    {
        Console.WriteLine("Mostrando todos los libros registrados.");
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("Mostrando libros disponibles.");
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("Mostrando libros prestados.");
    }

    static void ViewBookDetail()
    {
        Console.WriteLine("Mostrando detalle del libro por ID o ISBN.");
    }

    static void UpdateBookMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== ACTUALIZAR LIBRO ===");
            Console.WriteLine("1. Editar título");
            Console.WriteLine("2. Editar autor");
            Console.WriteLine("3. Editar año / categoría");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    EditBookTitle();
                    break;

                case 2:
                    EditBookAuthor();
                    break;

                case 3:
                    EditBookYearCategory();
                    break;
            }

        } while (opcion != 0);
    }

    static void EditBookTitle()
    {
        Console.WriteLine("Editando título del libro.");
    }

    static void EditBookAuthor()
    {
        Console.WriteLine("Editando autor del libro.");
    }

    static void EditBookYearCategory()
    {
        Console.WriteLine("Editando año o categoría del libro.");
    }

    static void DeleteBook()
    {
        Console.WriteLine("Validar que el libro no esté prestado antes de eliminar.");
    }

    // MENÚ USUARIOS

    static void ShowUsersMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ USUARIOS ===");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Ver detalle");
            Console.WriteLine("4. Actualizar usuario");
            Console.WriteLine("5. Eliminar usuario");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    RegisterUser();
                    break;

                case 2:
                    ListUsers();
                    break;

                case 3:
                    ViewUserDetail();
                    break;

                case 4:
                    UpdateUserMenu();
                    break;

                case 5:
                    DeleteUser();
                    break;
            }

        } while (opcion != 0);
    }

    static void RegisterUser()
    {
        Console.WriteLine("Registrando nuevo usuario.");
    }

    static void ListUsers()
    {
        Console.WriteLine("Mostrando lista de usuarios.");
    }

    static void ViewUserDetail()
    {
        Console.WriteLine("Mostrando detalle del usuario.");
    }

    static void UpdateUserMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== ACTUALIZAR USUARIO ===");
            Console.WriteLine("1. Editar nombre");
            Console.WriteLine("2. Editar contacto");
            Console.WriteLine("3. Activar / Desactivar");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    EditUserName();
                    break;

                case 2:
                    EditUserContact();
                    break;

                case 3:
                    ToggleUserActiveStatus();
                    break;
            }

        } while (opcion != 0);
    }

    static void EditUserName()
    {
        Console.WriteLine("Editando nombre del usuario.");
    }

    static void EditUserContact()
    {
        Console.WriteLine("Editando contacto del usuario.");
    }

    static void ToggleUserActiveStatus()
    {
        Console.WriteLine("Activando o desactivando usuario.");
    }

    static void DeleteUser()
    {
        Console.WriteLine("Validar que el usuario no tenga préstamos activos.");
    }

    // MENÚ PRÉSTAMOS
    
    static void ShowLoansMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ PRÉSTAMOS ===");
            Console.WriteLine("1. Crear préstamo");
            Console.WriteLine("2. Listar préstamos");
            Console.WriteLine("3. Ver detalle");
            Console.WriteLine("4. Registrar devolución");
            Console.WriteLine("5. Eliminar préstamo");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    CreateLoan();
                    break;

                case 2:
                    ListLoansMenu();
                    break;

                case 3:
                    ViewLoanDetail();
                    break;

                case 4:
                    RegisterReturn();
                    break;

                case 5:
                    DeleteLoan();
                    break;
            }

        } while (opcion != 0);
    }

    static void CreateLoan()
    {
        Console.WriteLine("Crear préstamo.");
        Console.WriteLine("Validaciones: usuario activo, libro disponible.");
    }

    static void ListLoansMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== LISTAR PRÉSTAMOS ===");
            Console.WriteLine("1. Todos");
            Console.WriteLine("2. Activos");
            Console.WriteLine("3. Cerrados");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    ListLoansAll();
                    break;

                case 2:
                    ListLoansActive();
                    break;

                case 3:
                    ListLoansClosed();
                    break;
            }

        } while (opcion != 0);
    }

    static void ListLoansAll()
    {
        Console.WriteLine("Mostrando todos los préstamos.");
    }

    static void ListLoansActive()
    {
        Console.WriteLine("Mostrando préstamos activos.");
    }

    static void ListLoansClosed()
    {
        Console.WriteLine("Mostrando préstamos cerrados.");
    }

    static void ViewLoanDetail()
    {
        Console.WriteLine("Mostrando detalle del préstamo.");
    }

    static void RegisterReturn()
    {
        Console.WriteLine("Registrar devolución y marcar libro disponible.");
    }

    static void DeleteLoan()
    {
        Console.WriteLine("Eliminar préstamo según reglas del sistema.");
    }

    // BÚSQUEDAS Y REPORTES

    static void ShowSearchReportsMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== BÚSQUEDAS Y REPORTES ===");
            Console.WriteLine("1. Buscar libro");
            Console.WriteLine("2. Buscar usuario");
            Console.WriteLine("3. Reportes");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    SearchBook();
                    break;

                case 2:
                    SearchUser();
                    break;

                case 3:
                    ShowReportsMenu();
                    break;
            }

        } while (opcion != 0);
    }

    static void SearchBook()
    {
        Console.WriteLine("Buscar libro por título, autor o categoría.");
    }

    static void SearchUser()
    {
        Console.WriteLine("Buscar usuario por nombre o ID.");
    }

    static void ShowReportsMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== REPORTES ===");
            Console.WriteLine("1. Reporte por usuario");
            Console.WriteLine("2. Reporte por libro");
            Console.WriteLine("3. Reporte vencidos");
            Console.WriteLine("4. Resumen");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    ReportByUser();
                    break;

                case 2:
                    ReportByBook();
                    break;

                case 3:
                    ReportOverdue();
                    break;

                case 4:
                    ReportSummary();
                    break;
            }

        } while (opcion != 0);
    }

    static void ReportByUser()
    {
        Console.WriteLine("Mostrando reporte por usuario.");
    }

    static void ReportByBook()
    {
        Console.WriteLine("Mostrando reporte por libro.");
    }

    static void ReportOverdue()
    {
        Console.WriteLine("Mostrando préstamos vencidos.");
    }

    static void ReportSummary()
    {
        Console.WriteLine("Mostrando resumen general.");
    }

    // PERSISTENCIA

    static void ShowPersistenceMenu()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== GUARDAR / CARGAR ===");
            Console.WriteLine("1. Guardar datos");
            Console.WriteLine("2. Cargar datos");
            Console.WriteLine("3. Reiniciar datos");
            Console.WriteLine("0. Volver");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    SaveData();
                    break;

                case 2:
                    LoadData();
                    break;

                case 3:
                    ResetData();
                    break;
            }

        } while (opcion != 0);
    }

    static void SaveData()
    {
        Console.WriteLine("Datos guardados correctamente.");
    }

    static void LoadData()
    {
        Console.WriteLine("Datos cargados.");
    }

    static void ResetData()
    {
        Console.Write("¿Está seguro de reiniciar los datos? (S/N): ");
        string r = Console.ReadLine();

        if (r.ToUpper() == "S")
        {
            Console.WriteLine("Datos reiniciados.");
        }
        else
        {
            Console.WriteLine("Operación cancelada.");
        }
    }

    // SALIR //

    static void ConfirmExitAndSave()
    {
        Console.Write("¿Guardar antes de salir? (S/N): ");
        string r = Console.ReadLine();

        if (r.ToUpper() == "S")
        {
            SaveData();
        }

        Console.WriteLine("Saliendo del sistema...");
    }
}
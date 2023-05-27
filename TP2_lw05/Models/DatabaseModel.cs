using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class DatabaseModel
{
    [DisplayName("Идентификатор")]
    public int Id { get; set; }

    [DisplayName("Название")]
    public string Name { get; set; }

    [DisplayName("Дата создания")]
    [DataType(DataType.Date)]
    public DateTime CreatedDate { get; set; }

    [DisplayName("Автор")]
    public string Author { get; set; }

    [DisplayName("Количество записей")]
    public int RecordCount { get; set; }

    [DisplayName("Рейтинг")]
    public double Rating { get; set; }
}

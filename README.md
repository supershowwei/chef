### StringExtension

- Left()
- Right()
- ToHtml() : Convert unicode word to &#...; format.
- EqualsIgnoreCase()
- EndsWithIgnoreCase()
- StartsWithIgnoreCase()
- ContainsIgnoreCase()

### ObjectExtension

- ExtEquals<T>() : Compare between two objects of T.
- IIF<T>() : If true, return T value; If false, return another T value.

### EnumerableExtension

- TakeLast<T>()

### DateTimeExtension

- SpecifyTime() : Set specific time.
- ToDateTime() : Wrapper DateTime.ParseExact(). If IFormatProvider is null, use CultureInfo.InvariantCulture as default.

### DataExtension

- ToDataTable<T, TColumns>() : Convert T to DataTable.

Examples:
```cs
// Common used.
List<T>().ToDataTable(x => x);

// Return DataTable only Id and Name columns
List<T>().ToDataTable(x => new { x.Id, x.Name });

// If property name of T is different from column name.
// We can hook System.ComponentModel.DataAnnotations.Schema.ColumnAttribute on property of T.
...
[Column("No")]
public int Id { get; set; }
...

```

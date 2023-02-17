using System.Text.Json.Serialization;

namespace LiveSkladSDK.LiveSkladModels;

public class Status
{
    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}

public class Closed
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("elements")]
    public List<Element> Elements { get; set; }
}

public class  StatusData
{
    [JsonPropertyName("new")]
    public New New { get; set; }

    [JsonPropertyName("inWork")]
    public InWork InWork { get; set; }

    [JsonPropertyName("wait")]
    public Wait Wait { get; set; }

    [JsonPropertyName("finish")]
    public Finish Finish { get; set; }

    [JsonPropertyName("closed")]
    public Closed Closed { get; set; }
}

public class Element
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("sort")]
    public int Sort { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }

    [JsonPropertyName("isPayRequired")]
    public bool IsPayRequired { get; set; }

    [JsonPropertyName("roles")]
    public List<Role> Roles { get; set; }
}

public class Finish
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("elements")]
    public List<Element> Elements { get; set; }
}

public class InWork
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("elements")]
    public List<Element> Elements { get; set; }
}

public class New
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("elements")]
    public List<Element> Elements { get; set; }
}

public class Role
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("isChecked")]
    public bool IsChecked { get; set; }

    [JsonPropertyName("isSet")]
    public bool IsSet { get; set; }

    [JsonPropertyName("isChange")]
    public bool IsChange { get; set; }
}
public class Wait
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("elements")]
    public List<Element> Elements { get; set; }
}

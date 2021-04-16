Il2CppDumperUtils
---

Tools for working with the great [Il2CppDumper](https://github.com/Perfare/Il2CppDumper), that makes it easier to extract data classes for (de)serialization.

- `dump libil2cpp.so.ipynb` automatically extract `libil2cpp.so` (and other things, probably) from full GG dump folder.
- `convert dump.cs.ipynb` generates usable C# code for data classes in `dump.cs`. Search for a class of interest, and the tool exports the class along with its dependencies to a source file (properties and fields only), which can almost be compiled directly.
- `ToJsonSchema` generate JSON schema for a class.

### Workflow

1. Dump memory with GG
1. Use the tools to produce a usable source file, then a schema
1. Verify the schema online
1. If something is wrong, modify the class a bit. A common change is from
    ```
    public SomeEnumType value;
    ```
    to
    ```
    [EnumDataType(SomeEnumType)]
    public string value;
    ```
    when using `StringEnumGenerationProvider` is not an option (e.g. the game mixes enum names and values in their JSON).
1. ???
1. Profit

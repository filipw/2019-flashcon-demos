#include "coreassembly.h"

.assembly SampleIL
{
  .ver 1:0:0:0
}

.module SampleIL.dll
// MVID: {1E97D84A-565B-49C5-B60A-F31A1A4ACE13}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x02ED0000

.class public abstract auto ansi sealed beforefieldinit SampleIL.Screw
  extends [CORE_ASSEMBLY]System.Object
{
  .method public hidebysig static !!T It<class T>(object o) cil managed aggressiveinlining
  {
        ldarg.0
        ret
  }
}

.class public auto ansi HelloEnum 
  extends [CORE_ASSEMBLY]System.Enum
{
  .field public specialname rtspecialname int32 value__       
  .field public static literal valuetype HelloEnum A = int32(0x0)       
  .field public static literal valuetype HelloEnum B = int32(0x1)
}

.class public auto ansi beforefieldinit Hello
  extends [CORE_ASSEMBLY]System.Object
{
  .method public hidebysig static string World() cil managed
  {
    IL_0001:  ldstr      "Hello World!"
    //IL_0006:  call       void [CORE_ASSEMBLY]System.Console::WriteLine(string)
    IL_000c:  ret
  }

    .method public hidebysig static int32 World() cil managed
  {
    IL_0001:  ldc.i4      42
    //IL_0006:  call       void [CORE_ASSEMBLY]System.Console::WriteLine(string)
    IL_000c:  ret
  }
}
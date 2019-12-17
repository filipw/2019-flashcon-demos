#include "coreassembly.h"

.assembly SampleIL
{
  .ver 1:0:0:0
}

.module SampleIL.dll

.class public abstract auto ansi sealed beforefieldinit SampleIL.Fuck
  extends [CORE_ASSEMBLY]System.Object
{
  .method public hidebysig static !!T It<class T>(object o) cil managed aggressiveinlining
  {
        ldarg.0
        ret
  }
}

.class public auto ansi beforefieldinit Hello
  extends [CORE_ASSEMBLY]System.Object
{
  .method public hidebysig static string World() cil managed
  {
    ldstr      "Hello World!"
    ret
  }

  .method public hidebysig static int32 World() cil managed
  {
    ldc.i4      42
    ret
  }
}
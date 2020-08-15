namespace Atcall

open System

module Utils =
    let loadFileText (path: string) = IO.File.ReadAllText path // TODO: Make file loader "safe" (no crash when file not exist)
    let isFileCompiled (path: string) = path.EndsWith ".actlc"

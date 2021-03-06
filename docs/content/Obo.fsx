(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"
#r "../../bin/BioFSharp.dll"
#r "../../bin/BioFSharp.IO.dll"
#r "../../bin/FSharp.Care.dll"
#r "../../bin/FSharp.Care.IO.dll"
(**
OBO format is a popular ontology file format. It can express a subset of the description logic language
OWL-DL 2.0 but in addition has standard syntax for representing important classes of meta-data including
as synonyms, references to publications and deprecated IDs. It is designed to be human readable and 
editable.

Reading Obo files
-------------------
*)


open FSharp.Care.IO
open BioFSharp.IO

let fileDir = __SOURCE_DIRECTORY__ + "/data/"  

let psiMs = 
    Seq.fromFile (fileDir + "Psi-MS.obo")
    |> Obo.parseOboTerms
    |> Seq.toArray



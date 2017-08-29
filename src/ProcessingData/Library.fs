namespace ProcessingData

open FSharp.Data

/// Stock prices example
type Stocks = CsvProvider<"./data/MSFT.csv">

/// Documentation for my library
///
/// ## Example
///
///     let h = Library.hello 1
///     printfn "%d" h
///
module Library = 
  /// Returns 42
  ///
  /// ## Parameters
  ///  - `num` - whatever
  let hello num = 42

  (*
  // Download the stock prices
  let msft = Stocks.Load("http://ichart.finance.yahoo.com/table.csv?s=MSFT")

  // Look at the most recent row. Note the 'Date' property
  // is of type 'DateTime' and 'Open' has a type 'decimal'
  let firstRow = msft.Rows |> Seq.head
  let lastDate = firstRow.Date
  let lastOpen = firstRow.Open

  // Print the prices in the HLOC format
  for row in msft.Rows do
    printfn "HLOC: (%A, %A, %A, %A)" row.High row.Low row.Open row.Close
  
  *)



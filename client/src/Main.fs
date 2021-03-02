module Main

open Fable.Core.JsInterop
open Elmish
open Elmish.React

importAll "./styles/global.scss"

Program.mkProgram App.init App.update App.render
|> Program.withReactSynchronous "feliz-app"
|> Program.run
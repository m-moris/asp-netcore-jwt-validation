# ASP.NET Core 2.0 Web API JWT Validation Sample

Web APIにアクセス制限をかけたかったので、挙動を確認するために作ったサンプルです。作りっぱなしにしておくとHDDのどこかに紛れてしまうので、GitHubに置いておきます。

## Framework
+ Visual Studio 2017
+ ASP.NET Core 2.0

## 実行

`git clone` してから、Visual Studio 2017で実行すると、ブラウザが開きます。

ユーザ名に、`admin`（パスワードはダミー）を指定すると、`admin role` が割り当てられ、それ以外のユーザ名だと、`user role` が割り当てられます。

緑のボタンでAPIを呼び出しますが、左のボタンはどちらでも呼び出せますが、右のボタンは`admin` のみです。

![screenshot](./screen.png)

## 参考

[Authentication In An ASP.NET Core API - Part 3: JSON Web Token | Pioneer Code](https://pioneercode.com/post/authentication-in-an-asp-dot-net-core-api-part-3-json-web-token)




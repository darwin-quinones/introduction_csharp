<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="form._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

    <title>Hello, world!</title>
</head>
<body>
    <form id="form1"  runat="server">
         <h1>Hello, world!</h1>

           <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Email address</label>
            <input type="email" name="email" id="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
            <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
          </div>
          <div class="mb-3">
            <label for="exampleInputPassword1" class="form-label">Password</label>
            <input type="password" name="password" id="password" class="form-control" id="exampleInputPassword1">
          </div>
          
          <button type="button" id="btn" class="btn btn-primary">Submit</button>
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk=" crossorigin="anonymous"></script>

    </form>

    <script type="text/javascript">
        $(document).ready(function () {
            let nombre = "Darwin"
            let id = 1
            let data = {
                objectUser: {
                    id: id,
                    name:nombre
                }
            }
            $('#form1').on('submit', function (e) {
                e.preventDefault()
                
            })

            $('#btn').click(function () {
                $.ajax({
                    url: 'default.aspx/Add',  // page where i have button listenener
                    data: JSON.stringify(data),
                    type: 'POST',
                    async: true,
                    cache: false,
                    contentType: "application/json; charset=utf-8",
                    success: function (result) {
                        console.log("inside sucess");
                        console.log("result: " + result);
                    },
                    error: function (request, error) {
                        // This callback function will trigger on unsuccessful action                
                        alert('Error!');
                        console.log(request)
                    }
                });
            })

            
        })

    </script>
</body>
</html>

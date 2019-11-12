var total = 0;
var count = 0;
var temp = 0;
var storeId;
var orderId;

function CreateOrder() {
    var xhttp = new XMLHttpRequest();
    var order = {
        customerId: "",
        date: 0,
        status:0
    }
    var customer = document.getElementById("customername").value;

    if (customer === "-- Choose a customer --") {
        alert("Please select a customer");
    } else {
        order.customerId = parseInt(customer);

        var d = new Date();
        var currentDate = JSON.stringify(d);
        order.date = currentDate.replace(/^"(.*)"$/, '$1');

        xhttp.open("POST", "api/order", true);
        xhttp.setRequestHeader('Content-Type', 'application/json');
        xhttp.send(JSON.stringify(order));
    }
}

function GetOrderId() {
    var xhttp = new XMLHttpRequest();

    xhttp.open("GET", "api/order", true);
    xhttp.send();

    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var orderIdTemp = JSON.parse(this.responseText);

            if (!orderIdTemp) {
                console.log("No orders created!");
            } else {
                orderId = orderIdTemp[orderIdTemp.length-1].id;
            }

        }
    };
}

function CreateOrderLine() {
    GetOrderId();

    if (orderId) {
        var xhttp = [];

        var orderLineData = {
            productId: "",
            quantity: "",
            unitPrice: "",
            status: 1,
            orderId: ""
        };

        var postIterator = this.sessionStorage.getItem("count");
        if (parseInt(postIterator) >= 0) {

            for (var i = 0; i <= parseInt(postIterator); i++) {
                var sessionTemp = sessionStorage.getItem("OrderItems" + i);

                xhttp[i] = new XMLHttpRequest();
                var session = JSON.parse(sessionTemp);
                orderLineData.productId = parseInt(session.productId);
                orderLineData.quantity = parseInt(session.quantity);
                orderLineData.unitPrice = parseInt(session.unitPrice);
                orderLineData.orderId = orderId;

                xhttp[i].open("POST", 'api/orderline', true);
                xhttp[i].setRequestHeader('Content-Type', 'application/json');
                xhttp[i].send(JSON.stringify(orderLineData));
            }
            sessionStorage.clear();
            alert("Order has been placed!");
            location.replace("/Orders/Index");
        } else {
            console.log("New Order placement needed!");
        }
    }
}

function ShowProduct(name) {
    var xhttp;

    if (name == "") {
        document.getElementById("productname").innerHTML = "";
        return;
    }

    xhttp = new XMLHttpRequest();

    xhttp.open("GET", "api/Products/" + name, true);
    xhttp.send();

    xhttp.onreadystatechange = function () {

        if (this.readyState == 4 && this.status == 200) {
            var obj = JSON.parse(this.responseText);

            document.getElementById("productId").value = obj[0].id;
            document.getElementById("description").innerHTML = obj[0].description;
            document.getElementById("unitprice").innerHTML = "Rs: " + obj[0].unitPrice;
            document.getElementById("description").value = obj[0].description;
            document.getElementById("unitprice").value = obj[0].unitPrice;
        } else {
            document.getElementById("description").innerHTML = "No value found!";
            document.getElementById("unitprice").innerHTML = "No value found!";
        }
    };
}

function AddOrderLine() {

    var table = document.getElementById("tableForm");
    var productName = document.getElementById("productname").value;
    var description = document.getElementById("description").value;
    var unitPrice = document.getElementById("unitprice").value;
    var quantity = document.getElementById("quantity").value;
    var productId = document.getElementById("productId").value;
    var editBtn = document.createElement("input");
    var deleteBtn = document.createElement("input");
    var quantityText = document.createElement("input");
    var unitPriceText = document.createElement("input")

    var grandTotal = document.getElementById("GrandTotal");
    var orderLine = {
        "productId":"",
        "productName": "",
        "description": "",
        "unitPrice": "",
        "quantity": "",
        "totalAmount": ""
    }

    editBtn.setAttribute('type', 'button');
    editBtn.setAttribute('value', 'Edit');
    editBtn.setAttribute('id', 'btnEdit');
    editBtn.classList.add("btn");
    editBtn.classList.add("btn-sm");
    editBtn.classList.add("btn-outline-warning");

    quantityText.setAttribute('type', 'number');
    quantityText.classList.add("form-control");
    quantityText.classList.add("col-md-4");
    quantityText.disabled = true;

    unitPriceText.setAttribute('type', 'number');
    unitPriceText.hidden = true;

    deleteBtn.setAttribute('type', 'button');
    deleteBtn.setAttribute('value', 'Delete');
    deleteBtn.classList.add("btn");
    deleteBtn.classList.add("btn-sm");
    deleteBtn.classList.add("btn-outline-danger");

    var row = table.insertRow(2);
    var productNameCell = row.insertCell(0);
    var descriptionCell = row.insertCell(1);
    var unitPriceCell = row.insertCell(2);
    var quantityTextCell = row.insertCell(3);
    var totalAmountCell = row.insertCell(4);
    var unitPriceTextCell = row.insertCell(5);
    var deleteButtonCell = row.insertCell(5);
    var editButtonCell = row.insertCell(5);


    editBtn.onclick = function () {

        if (temp == 0) {
            editBtn.setAttribute('value', 'Update');
            quantityText.disabled = false;
            temp++;
        } else {
            editBtn.setAttribute('value', 'Edit');
            quantityText.disabled = true;
            temp = 0;
        }
    }

    deleteBtn.onclick = function () {
        
        for (var i = 0; i < 7; i++) {
            row.deleteCell(0);
        }
        table.removeRow(2);
    }

    productNameCell.innerHTML = productName;
    descriptionCell.innerHTML = description;
    descriptionCell.colSpan = 2;
    unitPriceCell.innerHTML = unitPrice;
    quantityText.value = quantity;
    unitPriceText.value = unitPrice;
    totalAmountCell.innerHTML = (unitPrice * quantity);
    deleteButtonCell.appendChild(deleteBtn);
    editButtonCell.appendChild(editBtn);
    quantityTextCell.appendChild(quantityText);
    unitPriceTextCell.appendChild(unitPriceText);


    orderLine.productId = productId;
    orderLine.productName = productName;
    orderLine.description = description;
    orderLine.unitPrice = unitPrice;
    orderLine.quantity = quantity;
    orderLine.totalAmount = (unitPrice * quantity);
    total = total + (unitPrice * quantity);
    grandTotal.innerHTML = "Rs: " + total;

    quantityText.onchange = function () {
        var totaltemp = parseInt(unitPriceText.value) * parseInt(quantityText.value);
        console.log(unitPriceText.value + " :" + quantityText.value);
        totalAmountCell.innerHTML = totaltemp;
    }

    StoreOrderLine(orderLine);
}

function calTotal(quantity) {
    var unitprice = document.getElementById("unitprice").value;

    var total = parseInt(unitprice) * parseInt(quantity);

    document.getElementById("totalamount").innerHTML = "Rs: " + total;
}

function StoreOrderLine(order) {

    let orderList;
    let sessionCountSize = sessionStorage.getItem("count");

    if (sessionCountSize == null) {
        sessionStorage.setItem("count", 0);
    }

    if (sessionCountSize != null) {
        count = parseInt(sessionStorage.getItem("count"));
    }

    if (sessionCountSize == null) {
        orderList = order;
        sessionStorage.setItem("OrderItems" + count, JSON.stringify(orderList));
        count = count + 1;
    }
    else {
        orderList = order;

        count = count + 1;
        sessionStorage.setItem("count", count);
        sessionStorage.setItem("OrderItems" + count, JSON.stringify(orderList));
    }

}

window.onload = function getSession() {

    var table = document.getElementById("tableForm");
    var editBtn = document.createElement("input");
    var deleteBtn = document.createElement("input");
    var grandTotal = document.getElementById("GrandTotal");

    let sessionCountSize = sessionStorage.getItem("count");

    if (sessionCountSize != null) {
        count = parseInt(sessionStorage.getItem("count"));


        if (count >= 0) {

            for (var i = 0; i <= count; i++) {

                var sizeOfSession = this.sessionStorage.getItem("OrderItems" + i);
                var orders = JSON.parse(sizeOfSession);

                var editBtn = document.createElement("input");
                var deleteBtn = document.createElement("input");

                editBtn.setAttribute('type', 'button');
                editBtn.setAttribute('value', 'Edit');
                editBtn.setAttribute('id','btnEdit');
                editBtn.classList.add("btn");
                editBtn.classList.add("btn-sm");
                editBtn.classList.add("btn-outline-warning");

                deleteBtn.setAttribute('type', 'button');
                deleteBtn.setAttribute('value', 'Delete');
                deleteBtn.classList.add("btn");
                deleteBtn.classList.add("btn-sm");
                deleteBtn.classList.add("btn-outline-danger");

                var row = table.insertRow(2);

                var productNameCell = row.insertCell(0);
                var descriptionCell = row.insertCell(1);
                descriptionCell.colSpan = 2;

                var unitPriceCell = row.insertCell(2);
                var quantityCell = row.insertCell(3);
                var totalAmountCell = row.insertCell(4);
                var deleteButtonCell = row.insertCell(5);
                var editButtonCell = row.insertCell(5);
                deleteButtonCell.appendChild(deleteBtn);
                editButtonCell.appendChild(editBtn);


                productNameCell.innerHTML = orders.productId;
                descriptionCell.innerHTML = orders.description;
                unitPriceCell.innerHTML = "Rs: " + orders.unitPrice;
                quantityCell.innerHTML = orders.quantity;
                totalAmountCell.innerHTML = "Rs: " + orders.totalAmount;

                total = total + parseInt(orders.totalAmount);
            }
        }
    }
    else {
        console.log("No session available");
    }

    grandTotal.innerHTML = "Rs: " + total;
}

var total = 0;
var count = 0;

function StoreOrderLine(order) {

    let orderList = [];
    let sessionCountSize = localStorage.getItem("count");

    if (sessionCountSize == null) {
        localStorage.setItem("count", 0);
    }

    if (sessionCountSize != null) {
        count = parseInt(localStorage.getItem("count"));
    }

    if (sessionCountSize == null) {
        orderList.push(order);
        localStorage.setItem("OrderItems" + count, JSON.stringify(orderList));
        count = count + 1;
    }
    else {
        orderList.push(order);

        count = count + 1;
        localStorage.setItem("count", count);
        localStorage.setItem("OrderItems" + count, JSON.stringify(orderList));
    }

}

function AddOrderLine() {

    var table = document.getElementById("tableForm");
    var productName = document.getElementById("productname").value;
    var description = document.getElementById("description").value;
    var unitPrice = document.getElementById("unitprice").value;
    var quantity = document.getElementById("quantity").value;
    var editBtn = document.createElement("input");
    var deleteBtn = document.createElement("input");
    var grandTotal = document.getElementById("GrandTotal");
    var orderLine = {
        "productId": "",
        "description": "",
        "unitPrice": "",
        "quantity": "",
        "totalAmount": ""
    }

    editBtn.setAttribute('type', 'button');
    editBtn.setAttribute('value', 'Edit');
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
    var unitPriceCell = row.insertCell(2);
    var quantityCell = row.insertCell(3);
    var totalAmountCell = row.insertCell(4);
    var deleteButtonCell = row.insertCell(5);
    var editButtonCell = row.insertCell(5);

    productNameCell.innerHTML = productName;
    descriptionCell.innerHTML = description;
    descriptionCell.colSpan = 2;
    unitPriceCell.innerHTML = "Rs: "+unitPrice;
    quantityCell.innerHTML = quantity;
    totalAmountCell.innerHTML = (unitPrice * quantity);
    deleteButtonCell.appendChild(deleteBtn);
    editButtonCell.appendChild(editBtn);

    orderLine.productId = productName;
    orderLine.description = description;
    orderLine.unitPrice = unitPrice;
    orderLine.quantity = quantity;
    orderLine.totalAmount = (unitPrice * quantity);
    total = total + (unitPrice * quantity);
    grandTotal.innerHTML = "Rs: " + total;

    StoreOrderLine(orderLine);
}

window.onload = function getSession() {

    var table = document.getElementById("tableForm");
    var editBtn = document.createElement("input");
    var deleteBtn = document.createElement("input");
    var grandTotal = document.getElementById("GrandTotal");

    let sessionCountSize = localStorage.getItem("count");

    if (sessionCountSize != null) {
        count = parseInt(localStorage.getItem("count"));


        if (count >= 0) {

            for (var i = 0; i <= count; i++) {

                let sizeOfSession = localStorage.getItem("OrderItems" + i);
                var orders = JSON.parse(sizeOfSession);

                var editBtn = document.createElement("input");
                var deleteBtn = document.createElement("input");

                editBtn.setAttribute('type', 'button');
                editBtn.setAttribute('value', 'Edit');
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


                productNameCell.innerHTML = orders[0].productId;
                descriptionCell.innerHTML = orders[0].description;
                unitPriceCell.innerHTML = "Rs: " + orders[0].unitPrice;
                quantityCell.innerHTML = orders[0].quantity;
                totalAmountCell.innerHTML = "Rs: " + orders[0].totalAmount;

                total = total + parseInt(orders[0].totalAmount);
            }
        }
    }
    else {
        console.log("No session available");
    }

    grandTotal.innerHTML = "Rs: " + total;
}

// There is a retail shop which need to manage the inventory, whenever some purchase is being made product quantity should be reduced, if quanity is less than 5 reorder request should be raised.
var Shop = /** @class */ (function () {
    function Shop() {
        this.sh = [
            { id: 1, product: "fruits", price: 10, quantity: 50 },
            { id: 2, product: "vegies", price: 20, quantity: 30 },
            { id: 3, product: "spices", price: 50, quantity: 80 },
            { id: 4, product: "food", price: 70, quantity: 40 }
        ];
    }
    Shop.prototype.AddProduct = function (Id, item, pri, quan) {
        try {
            this.sh.push({ id: Id, product: item, price: pri, quantity: quan });
            console.log("Product Added to inventory");
        }
        catch (e) {
            console.error(e);
        }
    };
    Shop.prototype.AddOrder = function (prod, quant) {
        this.sh.filter(function (produ, index, err) {
            if (produ.product == prod) {
                if (quant < 5) {
                    console.log("enter more than 5 quantity");
                    return;
                }
                else {
                    if (produ.quantity >= quant) {
                        produ.quantity = produ.quantity - quant;
                        console.log("Thank you for ordering");
                    }
                    else {
                        console.log("we are not having that much in stock");
                        return;
                    }
                }
            }
            else {
                console.log("Sorry for inconvenience product is not in inventory");
            }
        });
    };
    return Shop;
}());
var ord = new Shop();
ord.AddOrder("food", 10);
ord.AddOrder("vegies", 4);
ord.AddProduct(7, "utensils", 500, 10);
console.log(ord);

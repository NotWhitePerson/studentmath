const addToArray = require("../array");

test("add item to array", () => {
    const array = []
    const item = "alma";

    expect(addToArray(array, item)).toContain(item)
})
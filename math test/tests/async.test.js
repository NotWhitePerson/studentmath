const fetchData = require("../async");

test("async function x > 5 resolve true", async () => {
    await expect(fetchData(8)).resolves.toBeTruthy();
})

test("async function x < 5 reject false", async () => {
    await expect(fetchData(3)).rejects.toBeFalsy();
})
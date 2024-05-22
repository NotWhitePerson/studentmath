async function fetchData(error) {
    return new Promise((resolve, reject) => {
        if (error > 5) {
            resolve(true);
        } else {
            reject(false);
        }
    })
}

module.exports = fetchData;
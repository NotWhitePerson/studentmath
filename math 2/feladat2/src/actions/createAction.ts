"use server";

import axios from "axios";

export async function createAction(formData: FormData) {
    try {
        const result = await axios.post("https://dummy.restapiexample.com/api/v1/create", {
            name  : formData.get("name"),
            age   : formData.get("age"),
            salary: formData.get("salary"),
        })

        if (result.status === 200) {
            return true;
        }
        return false
    } catch (err) {
        return false
    }
}

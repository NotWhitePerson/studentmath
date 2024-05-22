<?php

namespace App\Http\Controllers;

use App\Models\CustomerTable;
use App\Models\Waiter;
use Illuminate\Http\Request;

class CustomerTableController extends Controller
{
    public function get()
    {
        return response()->json(CustomerTable::with("waiter")->get());
    }

    public function update(Waiter $waiter, Request $request)
    {
        $waiter->update($request->all());

        return response()->json($waiter);
    }
}

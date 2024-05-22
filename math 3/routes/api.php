<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "api" middleware group. Make something great!
|
*/


Route::group(["prefix" => "waiters"], function () {
    Route::post("/create", [\App\Http\Controllers\WaiterController::class, "create"]);
    Route::put("/update/{waiter}", [\App\Http\Controllers\WaiterController::class, "update"]);
});


Route::group(["prefix" => "customer-tables"], function () {
    Route::get("/", [\App\Http\Controllers\CustomerTableController::class, "get"]);
    Route::delete("/delete/{customertable}",  [\App\Http\Controllers\CustomerTableController::class, "delete"]);
});

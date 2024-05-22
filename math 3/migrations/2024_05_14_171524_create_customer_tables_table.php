<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('customer_tables', function (Blueprint $table) {
            $table->id();
            $table->string("code");
            $table->foreignId("waiter_id")->constrained("waiters")->onDelete("cascade");
            $table->string("place");
            $table->timestamps();

            $table->foreign("waiter_id")->references("id")->on("waiters");
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('customer_tables');
    }
};

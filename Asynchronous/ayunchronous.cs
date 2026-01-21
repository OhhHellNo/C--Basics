/*

Do you call any async methods (like ToListAsync)?
│
├─ NO → Don't use async/await at all
│        public IActionResult GetData() { return Ok("hello"); }
│
└─ YES → Do you need to do something with the result?
         │
         ├─ NO → Return Task directly (no async, no await)
         │        public Task<List<Vehicle>> GetAll()
         │        { 
         │            return _dbContext.Vehicles.ToListAsync(); 
         │        }
         │
         └─ YES → Use async + await
                  public async Task<IActionResult> GetAll()
                  {
                      var vehicles = await _dbContext.Vehicles.ToListAsync();
                      var count = vehicles.Count; // Working with result
                      return Ok(new { count, vehicles });
                  }
*/

export function Login() {
    return (
        <div className="row">
            <form>
                <div class="row g-3 align-items-center">
                    <div class="col-auto">
                        <label class="col-form-label">Vehicle Number</label>
                    </div>
                    <div class="col-auto">
                        <input type="text" class="form-control" />
                    </div>
                    <div class="col-auto">
                        <span class="form-text">
                            <button type="submit" className="btn btn-primary">Submit</button>
                        </span>
                    </div>
                </div>
            </form>
        </div >
    )

}

export default Login